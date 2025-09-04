using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Danh sách sinh viên";
            return View();
        }
        public IActionResult Details(int id = 1)
        {
            ViewBag.Title = "Chi tiết sinh viên";
            ViewBag.StudentId = id;
            return View();
        }
    }
}
