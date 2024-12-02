using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Week11_1_FirstController.Models;

namespace Week11_1_FirstController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> _products = new List<Product>()
        {
            new Product { Id = 1, Name = "Product1", Price = 200 },
            new Product { Id = 2, Name = "Product2", Price = 300 },
        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }

        [HttpGet("{id:int:min(1)}")] // iki get metodu olduğu için burada id'nin path'ten geleceğini belirttik
        public IActionResult Get(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpGet("search/{keyword:alpha:minLength(3)}")]
        public IActionResult Search(string keyword)
        {
            return Ok();
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery] string keyword, [FromQuery] int? page = 1)
        {
            return Ok();
        }


        [HttpGet("category/{categoryName}")]
        public IActionResult GetProductsByCategory(string categoryName)
        {
            return Ok();
        }


        [HttpPost]
        public IActionResult Post([FromBody] Product product) // verinin json'ın body'sinden geleceğini belirtiyoruz
        {
            var id = _products.Max(x => x.Id) + 1;
            product.Id = id;
            _products.Add(product);

            return CreatedAtAction(
                   nameof(Get),                // 1. Parametre: Hangi metoda yönlendirileceğini belirtir (örn. `Get` metodu).
                   new { id = product.Id },    // 2. Parametre: Rota verileri (örneğin, `id` parametresi).
                   product);                    // 3. Parametre: Döndürülecek içerik.
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            if (product == null || id != product.Id)
            {
                return BadRequest();
            }

            var existingProduct = _products.FirstOrDefault(x => x.Id == id);

            if (existingProduct == null)
            {
                return NotFound();  
            }

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;

            return Ok(existingProduct);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var existingProduct = _products.FirstOrDefault(y => y.Id == id);

            if (existingProduct == null)
            {
                return NotFound();
            }

            _products.Remove(existingProduct);

            return NoContent();
        }
    }
}
