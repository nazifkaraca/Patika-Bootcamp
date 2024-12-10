using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Week12_6_Ecommercial.Data;
using Week12_6_Ecommercial.Dto;
using Week12_6_Ecommercial.Models;

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

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdatePrice(int id, [FromBody] JsonPatchDocument<Product> patchDocument)
        {
            if (patchDocument is null) return BadRequest("Patch dökümanı boş olamaz.");

            var product = await _context.Products.FindAsync(id);

            if (product == null) return NotFound("Ürün bulunamadı");

            try
            {
                patchDocument.ApplyTo(product);

                if (product.Price <= 0) return BadRequest("Fiyat sıfır veya sıfırdan küçük olamaz.");

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                var entry = ex.Entries.Single();

                var clientValues = entry.Entity as Product;

                var databaseEntry = entry.GetDatabaseValues();

                if (databaseEntry == null) return NotFound("Ürün silinmiş.");

                var databaseValues = databaseEntry.ToObject() as Product;

                ModelState.AddModelError(string.Empty, "Bu ürün fiyatı daha önce başka bir kullanıcı tarafından değiştirilmiştir.");

                return Conflict(new
                {
                    Message = "Conflict oluştu. Ürün başka biri tarafından güncellendi.",
                    CurrentDatabaseValues = databaseValues,
                    YourAttemptedValues = clientValues,
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Hata oluştu.");
            }

            return Ok();
        }
    }
}
