using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Survivor.Data;
using Survivor.Data.Entity;

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
            return _context.Competitors.ToList();
        }

        [HttpGet("{id:int:min(1)}")]
        public ActionResult<Competitor> GetById(int id)
        {
            var competitor = _context.Competitors.FirstOrDefault(x => x.Id == id);

            if (competitor == null) return NotFound("Competitor is not found.");

            return Ok(competitor);
        }

        [HttpGet("categories/{CategoryId}")]
        public ActionResult<List<Competitor>> GetByCategory(int categoryId)
        {
            var competitors = _context.Competitors.Where(x => x.CategoryId == categoryId);

            return Ok(competitors);
        }
    }
}
