using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survivor.Data;
using Survivor.Data.Entity;
using Survivor.Dto;
using System.Text.Json;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorsController : ControllerBase
    {
        private readonly SurvivorContext _context;

        public CompetitorsController(SurvivorContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Competitor>> Get()
        {
            var competitors = _context.Competitors.ToList();
            return Ok(new
            {
                TotalCount = competitors.Count,
                Competitors = competitors
            });
        }

        [HttpGet("{id:int:min(1)}")]
        public ActionResult<Competitor> GetById(int id)
        {
            var competitor = _context.Competitors.FirstOrDefault(x => x.Id == id);

            if (competitor == null) return NotFound("Competitor is not found.");

            return Ok(competitor);
        }

        [HttpGet("categories/{CategoryId}")]
        public ActionResult<List<Competitor>> GetByCategory(int CategoryId)
        {
            var competitors = _context.Categories.Where(x => x.Id == CategoryId)
                                                 .SelectMany(x => x.Competitors)
                                                 .ToList();

            return Ok(new
            {
                TotalCount = competitors.Count,
                Competitors = competitors
            });
        }

        [HttpPost]
        public IActionResult Create([FromBody] CompetitorDto competitor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newCompetitor = new Competitor
            {
                FirstName = competitor.FirstName,
                LastName = competitor.LastName,
                CategoryId = competitor.CategoryId,
            };

            _context.Competitors.Add(newCompetitor);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = newCompetitor.Id }, newCompetitor);
        }

        [HttpPut("{id:int:min(1)}")]
        public IActionResult UpdateById(int id, [FromBody] CompetitorDto competitor)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var existingCompetitor = _context.Competitors.FirstOrDefault(x => x.Id == id);

            if (existingCompetitor == null) return NotFound($"Competitor with {id} id not found.");

            // Check if JSON is default "string"
            existingCompetitor.FirstName = competitor.FirstName == "string"
                                         ? existingCompetitor.FirstName // If null or default, keep the original name
                                         : competitor.FirstName; // else update the name

            // Check if JSON is default "string"
            existingCompetitor.LastName = competitor.LastName == "string"
                                        ? existingCompetitor.LastName // If null or default, keep the original surname
                                        : competitor.LastName; // else update the surname

            // Check if JSON is default null 
            existingCompetitor.CategoryId = competitor.CategoryId == 0 
                                          ? existingCompetitor.CategoryId // If null, keep the original category id
                                          : competitor.CategoryId; // else update the category

            existingCompetitor.ModifiedDate = DateTime.Now;


            _context.Competitors.Update(existingCompetitor);

            _context.SaveChanges();

            return Ok($"Competitor {existingCompetitor.FirstName} {existingCompetitor.LastName} is successfully updated.");
        }

        [HttpDelete("{id:int:min(1)}")]
        public IActionResult DeleteById(int id)
        {
            var competitor = _context.Competitors.FirstOrDefault(x => x.Id == id);

            if (competitor == null) return NotFound("Related competitor could not be found.");

            // Soft delete
            _context.Competitors.Remove(competitor);
            _context.SaveChanges();

            return Ok($"Hard delete for the competitor ({competitor.FirstName} {competitor.LastName}) completed.");
        }

        [HttpPatch("softdelete/{id:int:min(1)}")]
        public IActionResult SoftDelete(int id)
        {
            var competitor = _context.Competitors.FirstOrDefault(x => x.Id == id);
            if (competitor == null) return NotFound($"Competitor with {id} id not found.");

            competitor.IsDeleted = true;
            competitor.ModifiedDate = DateTime.Now;
            _context.SaveChanges();

            return Ok($"Competitor {competitor.FirstName} {competitor.LastName} ({id}) marked as deleted.");
        }
    }
}
