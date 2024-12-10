using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Week12_6_Ecommercial.Data;
using Week12_6_Ecommercial.Dto;
using Week12_6_Ecommercial.Models;

namespace Week12_6_Ecommercial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public OrdersController(EcommerceContext context)
        {
            _context = context; 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetById(int id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);

            if (order == null) return NotFound();

            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult<Order>> Create(CreateOrderDto order)
        {
            //_context.Orders.Add(order);

            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                // Create new order instance
                var newOrder = new Order
                {
                    CustomerId = order.CustomerId,
                    OrderDate = DateTime.Now,
                    TotalAmount = 0
                };

                // Add new order to Orders table
                _context.Orders.Add(newOrder);
                await _context.SaveChangesAsync();

                decimal totalAmount = 0;

                // Iterate every item in the order
                foreach (var item in order.OrderItems)
                {
                    // Fint item in the Products table
                    var product = await _context.Products.FindAsync(item.productId);

                    // If item not found, throw an exception
                    if (product == null) throw new Exception($"{item.productId} ürün bulunamadı.");

                    // If stock inadequate, throw an exception
                    if (product.StockQuantity < item.quantity) throw new Exception($"{item.productId} yeterli stok yok.");

                    // All clear, create order details
                    var orderDetail = new OrderDetail
                    {
                        OrderId = newOrder.Id,
                        ProductId = item.productId,
                        Quantity = item.quantity,
                        UnitPrice = product.Price
                    };

                    // Add new order details to the table
                    _context.OrderDetails.Add(orderDetail);

                    // Calculate total amount
                    totalAmount += orderDetail.Quantity * orderDetail.UnitPrice;

                    // Decrease stock quantity
                    product.StockQuantity -= item.quantity;

                    // Update products table with new status
                    _context.Products.Update(product);
                }

                newOrder.TotalAmount = totalAmount;

                _context.Orders.Update(newOrder);

                await _context.SaveChangesAsync();

                await transaction.CommitAsync();

                return CreatedAtAction(nameof(GetById), new { id = newOrder.Id }, newOrder);
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }


        [HttpDelete("deleteold")]
        public async Task<IActionResult> DeleteOldOrders([FromQuery] int yearsOld = 1)
        {
            if (yearsOld < 0) return BadRequest("Yıl bilgisi pozitif sayı olmalıdır.");

            var cutoffDate = DateTime.Now.AddYears(-yearsOld);

            int totalDeletedCount = 0;

            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                // Batch processing
                int batchSize = 1000;

                bool continueDeletion = true;

                while (continueDeletion)
                {
                    // Get old orders with details
                    var oldOrders = await _context.Orders
                                                      .Where(o => o.OrderDate < cutoffDate)
                                                      .Include(o => o.OrderDetails)
                                                      .Take(batchSize)
                                                      .ToListAsync();

                    // If no old orders left, break loop
                    if (oldOrders.Count == 0)
                    {
                        continueDeletion = false;
                        continue;
                    }

                    // Delete details of all orders
                    foreach (var oldOrder in oldOrders)
                    {
                        _context.OrderDetails.RemoveRange(oldOrder.OrderDetails);
                    }

                    // Delete all orders
                    _context.Orders.RemoveRange(oldOrders);

                    // Count deleted orders
                    var deletedCount = await _context.SaveChangesAsync();  

                    totalDeletedCount += deletedCount;
                }

                await transaction.CommitAsync();

                // Return informative message
                return Ok(new
                {
                    Message = $"{totalDeletedCount} adet kayıt detaylarıyla birlikte silindi.",
                    DeletedCount = totalDeletedCount
                });
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();

                return StatusCode(500, "Bir hata oluştu.");
            }
        }
    }
}
