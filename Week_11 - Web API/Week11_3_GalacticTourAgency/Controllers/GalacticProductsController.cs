using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week11_3_GalacticTourAgency.Models;

namespace Week11_3_GalacticTourAgency.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalacticProductsController : ControllerBase
    {
        private static List<GalacticProduct> _products = new List<GalacticProduct>
        {
            new GalacticProduct { Id = 1, GalacticRating = 5, ManifacturingDate = DateTime.Now.AddYears(-1), Name = "Product1", Planet = "Merkür", Price = 4 },
        };


        [HttpGet("{id}")]
        public ActionResult<GalacticProduct> Get(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }


        [HttpPost]
        public ActionResult<GalacticProduct> Post([FromBody] GalacticProduct product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            product.Id = _products.Max(x => x.Id) + 1;

            _products.Add(product);

            return CreatedAtAction(nameof(Post), new { id = product.Id }, product);

        }
    }
}
