using Day12_Lab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day12_Lab.Controllers
{
    [Route("Admin/Student")]
    public class StudentController : Controller
    {
        public List<Student> listStudents = new List<Student>();
        public StudentController()
        {
            listStudents = new List<Student>()
            {
            new Student()
            {
                Id = 101,
                Name = "Hải Nam",
                Branch = Branch.IT,
                Gender = Gender.Male,
                IsRegular = true,
                Address = "A1-2018",
                Email = "nam@g.com"
            },

            new Student()
            {
                Id = 102,
                Name = "Minh Tú",
                Branch = Branch.BE,
                Gender = Gender.Female,
                IsRegular = true,
                Address = "A1-2019",
                Email = "tu@g.com"
            },

            new Student()
            {
                Id = 103,
                Name = "Hoàng Phong",
                Branch = Branch.CE,
                Gender = Gender.Male,
                IsRegular = false,
                Address = "A1-2020",
                Email = "phong@g.com"
            },

            new Student()
            {
                Id = 104,
                Name = "Xuân Mai",
                Branch = Branch.EE,
                Gender = Gender.Female,
                IsRegular = false,
                Address = "A1-2021",
                Email = "mai@g.com"
            }
            };
        }
        [HttpGet]
        [Route("Add")]
        public IActionResult Create()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem(){ Text="IT", Value = "1"},
                new SelectListItem(){ Text="BE", Value = "2"},
                new SelectListItem(){ Text="CE", Value = "3"},
                new SelectListItem(){ Text ="EE", Value = "4"}
            };
            return View();
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Create(Student student, IFormFile? AvatarFile)
        {
            if(AvatarFile != null && AvatarFile.Length > 0)
            {
                var folder = Path.Combine("wwwroot", "avatars");
                if(!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                var fileName = DateTime.Now.Ticks + Path.GetExtension(AvatarFile.FileName);
                var filePath = Path.Combine(folder, fileName);

                using(var stream = new FileStream(filePath, FileMode.Create))
                {
                    AvatarFile.CopyToAsync(stream);
                }
                student.Avatar = "/avatars/" + fileName;
            }
            student.Id = listStudents.Last<Student>().Id + 1;
            listStudents.Add(student);
            return View("Index", listStudents);
        }
        [Route("List")]
        public IActionResult Index()
        {
            return View(listStudents);
        }
    }
}
