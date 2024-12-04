using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Week11_4_CrazyMusicians.Models;

namespace Week11_4_CrazyMusicians.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusiciansController : ControllerBase
    {
        private static List<Musician> _musicians = new()
        {
            new Musician { Id = 1, FullName = "Ahmet Çalgı", Occupation = "Ünlü Çalgı Çalar", Feature = "Her zaman yanlış nota çalar, ama çok eğlenceli" },
            new Musician { Id = 2, FullName = "Zeynep Melodi", Occupation = "Popüler Melodi Yazarı", Feature = "Şarkıları yanlış anlaşılır ama çok popüler" },
            new Musician { Id = 3, FullName = "Cemil Akor", Occupation = "Çılgın Akorist", Feature = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli" },
            new Musician { Id = 4, FullName = "Fatma Nota", Occupation = "Sürpriz Nota Üreticisi", Feature = "Nota üretirken sürekli sürprizler hazırlar" },
            new Musician { Id = 5, FullName = "Hasan Ritim", Occupation = "Ritim Canavarı", Feature = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir" },
            new Musician { Id = 6, FullName = "Elif Armoni", Occupation = "Armoni Ustası", Feature = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır" },
            new Musician { Id = 7, FullName = "Ali Perde", Occupation = "Perde Uygulayıcı", Feature = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir" },
            new Musician { Id = 8, FullName = "Ayşe Rezonans", Occupation = "Rezonans Uzmanı", Feature = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır" },
            new Musician { Id = 9, FullName = "Murat Ton", Occupation = "Tonlama Meraklısı", Feature = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç" },
            new Musician { Id = 10, FullName = "Selin Akor", Occupation = "Akor Sihirbazı", Feature = "Akorları değiştirdiğinde bazen sihirli bir hava yaratır" },
        };

        // Default get
        [HttpGet]
        public ActionResult<IEnumerable<Musician>> Get()
        {
            return _musicians.ToList();
        }

        // Get By Id
        [HttpGet("{id:int:min(1)}")]
        public ActionResult<Musician> GetById(int id)
        {
            var musician = _musicians.FirstOrDefault(x => x.Id == id);

            if (musician == null)
            {
                return NotFound($"Musician with {id} id not found.");
            }

            return Ok(musician);
        }

        // Get By Name or Surname
        [HttpGet("search")]
        public ActionResult<IEnumerable<Musician>> GetByName([FromQuery] string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Name cannot be null.");
            }

            // Divide names and surnames for better query search
            var musician = _musicians
                .Where(x => x.FullName.Split(" ")
                .Any(part => part.Equals(name, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            if (!musician.Any())
            {
                return NotFound($"Musician with \"{name}\" not found");
            }

            return Ok(musician);
        }

        // Create new musician
        [HttpPost("post")]
        public ActionResult<Musician> Post([FromBody] Musician newMusician)
        {
            if (newMusician == null)
            {
                return BadRequest("Musician information cannot be null!");
            }

            newMusician.Id = _musicians.Max(x => x.Id) + 1;

            _musicians.Add(newMusician);

            return CreatedAtAction(nameof(Post), new { id = newMusician.Id }, newMusician);
        }

        // Patch a musician
        [HttpPatch("feature/change/{id:int:min(1)}")]
        public IActionResult ChangeFeature(int id, [FromBody] JsonPatchDocument<Musician> patchDocument)
        {

            var musician = _musicians.FirstOrDefault(x => x.Id == id);

            if (musician == null) { return NotFound($"Musician with {id} not found."); }

            patchDocument.ApplyTo(musician);

            return NoContent();
        }


        // Put a musician
        [HttpPut("name/update/{id:int:min(1)}/{newName}")]
        public IActionResult UpdateName(int id, string newName)
        {
            var musician = _musicians.FirstOrDefault(x => x.Id == id);

            if (musician == null) { return BadRequest($"Musician with {id} not found."); }

            musician.FullName = newName;

            return NoContent();
        }

        [HttpDelete("{id:int:min(1)}")]
        public IActionResult DeleteMusician(int id)
        {
            var musicianToRemove = _musicians.FirstOrDefault(x => x.Id == id);

            if (musicianToRemove is null) { return NotFound($"Musician with {id} not found."); }

            _musicians.Remove(musicianToRemove);

            return NoContent();
        }

        [HttpDelete("delete/search")]
        public IActionResult DeleteByName([FromQuery] string name)
        {
            int deleteCount = 0;

            var musiciansToRemove = _musicians
                .Where(x => x.FullName.Split(' ')
                .Any(part => part.Equals(name, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            if (!musiciansToRemove.Any()) { return NotFound($"There is no musician named {name} exists."); }

            foreach (var musician in musiciansToRemove)
            {
                _musicians.Remove(musician);
                deleteCount++;
            }

            return Ok("Deleted entries: " + deleteCount);
        }
    }
}
