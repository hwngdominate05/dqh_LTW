using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.Net.Cache;

namespace Day03View.Controllers
{
    public class PassDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewDataDemo()
        {
            ViewData["name"] = "Test";
            ViewData["time"] = DateTime.Now;

            var student = new Student()
            {
                Id = 1,
                Name = "Hung",
                Age = 20,
                Gender = "Nam"
            };
            ViewBag.Student = student;


            return View();
        }
    }
}
