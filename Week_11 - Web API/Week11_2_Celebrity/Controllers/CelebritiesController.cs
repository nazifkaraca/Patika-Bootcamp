using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week11_2_Celebrity.Models;

namespace Week11_2_Celebrity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CelebritiesController : ControllerBase
    {
        private static readonly List<Celebrity> celebrities = new List<Celebrity>()
        {
            new Celebrity { Id = 1, Name = "Tarkan", Profession = "Pop Müzik Sanatçısı" },
            new Celebrity { Id = 2, Name = "Sıla", Profession = "Pop Müzik Sanatçısı" },
            new Celebrity { Id = 3, Name = "Kenan İmirzalioğlu", Profession = "Oyuncu" },
            new Celebrity { Id = 4, Name = "Bergüzar Korel", Profession = "Oyuncu" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Celebrity>> Get()
        {
            return Ok(celebrities);
        }

        // GET: api/celebrities/5
        [HttpGet("{id}")]
        public ActionResult<Celebrity> Get(int id)
        {
            var celebrity = celebrities.FirstOrDefault(x => x.Id == id);

            if (celebrity == null)
            {
                return NotFound();
            }

            return Ok(celebrity);
        }

        // POST api/celebrities
        [HttpPost]
        public ActionResult<Celebrity> Post([FromBody] Celebrity celebrity)
        {
            celebrity.Id = celebrities.Max(x => x.Id) + 1;

            celebrities.Add(celebrity);

            return CreatedAtAction(nameof(Get), new { id = celebrity.Id }, celebrity);
        }

        // PUT api/celebrities/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Celebrity updatedCeleb)
        {
            var existingCeleb = celebrities.FirstOrDefault(c => c.Id == id);

            if (existingCeleb == null)
            {
                return NotFound();
            }

            existingCeleb.Name = updatedCeleb.Name;
            existingCeleb.Profession = updatedCeleb.Profession;

            return NoContent();
        }

        // DELETE api/celebrities/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var celebrity = celebrities.FirstOrDefault(x => x.Id == id);

            if (celebrity == null)
            {
                return NotFound();
            }

            celebrities.Remove(celebrity);
            return NoContent();
        }

    }
}
