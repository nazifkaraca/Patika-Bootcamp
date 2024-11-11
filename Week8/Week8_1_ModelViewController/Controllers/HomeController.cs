using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Week8_1_ModelViewController.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Biography()
        {
            return View();
        }

        public ActionResult Interests()
        {
            return View();
        }
    }
}
