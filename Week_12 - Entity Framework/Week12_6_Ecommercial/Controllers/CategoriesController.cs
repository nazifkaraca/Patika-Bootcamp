using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Week12_6_Ecommercial.Data;
using Week12_6_Ecommercial.Models;

namespace Week12_6_Ecommercial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public CategoriesController(EcommerceContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetById(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);

            if (category == null) return NotFound();

            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult<Category>> Create(Category category)
        {
            _context.Categories.Add(category);

            await _context.SaveChangesAsync();

            var newProduct = new Product
            {
                CategoryId = category.Id,
                Description = "Kategori ekleden geldi.",
                Name = "Product 1",
                Price = 10,
                StockQuantity = 10,
            };

            _context.Products.Add(newProduct);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id =  category.Id }, category);
        }
    }
}
