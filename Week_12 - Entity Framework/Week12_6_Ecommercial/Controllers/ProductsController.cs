using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Week12_6_Ecommercial.Data;
using Week12_6_Ecommercial.Dto;

namespace Week12_6_Ecommercial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public ProductsController(EcommerceContext context)
        {
            _context = context;
        }

        [HttpPut("{productName}")]
        public async Task<IActionResult> UpdateProduct(string productName, ProductUpdateDto updateDto)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Name == productName);

            if (product == null) return NotFound();

            try
            {
                product.Price *= (1 + (updateDto.PriceIncreasePercentage / 100));
                product.StockQuantity += updateDto.StockIncrease;

                await _context.SaveChangesAsync();

                return Ok(new
                {
                    Message = "Ürün güncellendi",
                    ProductName = productName,
                    NewPrice = product.Price,
                    NewStockQuantity = product.StockQuantity
                });
            }
            catch (Exception)
            {

                return StatusCode(500, "Ürün güncellenirken bir hata oluştu.");
            }
        }
    }
}
