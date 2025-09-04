using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Danh sách khóa học";
            return View();
        }
        public IActionResult Info(int id = 1)
        {
            ViewBag.Title = "Thông tin khóa học";
            ViewBag.CourseId = id;
            return View();
        }
    }
}
