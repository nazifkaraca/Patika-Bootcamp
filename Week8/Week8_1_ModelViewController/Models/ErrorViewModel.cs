using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Week8_1_ModelViewController.Models
{
    public class ErrorViewModel : Controller
    {
        // GET: ErrorViewModel
        public ActionResult Index()
        {
            return View();
        }

        // GET: ErrorViewModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ErrorViewModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ErrorViewModel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ErrorViewModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ErrorViewModel/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ErrorViewModel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ErrorViewModel/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
