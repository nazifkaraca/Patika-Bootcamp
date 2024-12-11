using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survivor.Data;
using Survivor.Data.Entity;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly SurvivorContext _context;

        public CategoriesController(SurvivorContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Categories.ToList());
        }

        // Get by category id
        [HttpGet("{id:int:min(1)}")]
        public ActionResult<Category> GetById(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);

            if (category == null) return NotFound($"Category with {id} id not found.");

            return Ok(category);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Category category)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var newCategory = new Category
            {
                Name = category.Name,
                IsDeleted = category.IsDeleted,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = null,
            };

            _context.Categories.Add(newCategory);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = newCategory.Id }, newCategory);
        }

        [HttpPut("{id:int:min(1)}")]
        public IActionResult UpdateById(int id)
        {
            var existingCategory = _context.Categories.FirstOrDefault(x => x.Id == id);

            if (existingCategory == null) return NotFound($"Category with {id} id not found.");

            _context.Categories.Update(existingCategory);
            _context.SaveChanges();

            return Ok(existingCategory);
        }

        [HttpDelete("{id:int:min(1)}")]
        public IActionResult DeleteById(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);

            if (category == null) return NotFound($"Category with {id} id not found.");

            _context.Categories.Remove(category);
            _context.SaveChanges();

            return Ok(category);
        }

        [HttpPatch("softdelete/{id:int:min(1)}")]
        public IActionResult SoftDelete(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);

            if (category == null) return NotFound($"Category with {id} id not found.");

            category.IsDeleted = true;
            category.ModifiedDate = DateTime.Now;

            _context.Categories.Update(category);
            _context.SaveChanges();

            return Ok($"Competitor {category.Name} ({id}) marked as deleted.");
        }

    }
}
