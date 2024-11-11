using Microsoft.AspNetCore.Mvc;
using Week8_2_MVCProject.Models;

namespace Week8_2_MVCProject.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new()
            {
                Id = 2,
                FirstName = "Nazif",
                LastName = "Karaca",
                Email = "nazif808@gmail.com"
            };

            List<Order> orders = new()
            {
                new(1, "Makarna", 9.99m, 1),
                new(2, "Kedi Maması", 100m, 4),
                new(3, "Çitoz", 5m, 5),
                new(4, "Ton Balığı", 25m, 3)
            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Order = orders,
                Greetings = "Merhaba, Karaca Markete Hoşgeldiniz!"
            };

            return View(viewModel);
        }
    }
}
