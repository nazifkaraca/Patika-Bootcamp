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

                return CreatedAtAction(nameof(GetById), new { id = newOrder.Id }, newOrder);
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}
