using System;
using System.Web.Mvc;
using System.Xml.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult InputForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InputForm(HomeModel homeModel)
        {
            string fileName =
                "D:\\Education\\SummerCamp\\2week\\ASP.NET MVC\\WebApplication1\\WebApplication1\\bin\\roslyn\\XML_Form.xml";
            XDocument doc = XDocument.Load(fileName);
            XElement root = new XElement("User");
            root.Add(new XElement("name", homeModel.Name));
            root.Add(new XElement("email", homeModel.Email));
            root.Add(new XElement("phone", homeModel.Phone));
            doc.Element("AllUsers").Add(root);
            doc.Save(fileName);
            
            return View("Thanks", homeModel);
        }
    }
}