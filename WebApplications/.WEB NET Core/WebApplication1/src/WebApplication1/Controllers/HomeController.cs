using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult MyTest()
        {
            var model = new TestModel()
            {
                FirstName = "Jimmy",
                LastName = "Moriarty",
                Email = "jimmymoriarty@gmail.com"
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult MyTest(TestModel model)
        {
            if (model.Names != null)
            {
                model.Names.Add(model.FirstName);
            }
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
