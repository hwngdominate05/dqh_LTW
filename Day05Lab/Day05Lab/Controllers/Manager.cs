using Day05Lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day05Lab.Controllers
{
    public class Manager : Controller
    {
        public List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                id = "001",
                name = "Hồ Việt Tùng",
                gender = 1,
                phone = "0123456789",
                email = "tungho29@example.com",
                salary = 1000,
                status = employeeStatus.Active,
            },
            new Employee()
            {
                id = "002",
                name = "Bùi Hải Đức",
                gender = 0,
                phone = "0123456789",
                email = "hduck13@example.com",
                salary = 1200,
                status = employeeStatus.Inactive,
            },
            new Employee()
            {
                id = "003",
                name = "Khúc Phương Nam",
                gender = 1,
                phone = "0123456789",
                email = "nam123@example.com",
                salary = 9000,
                status = employeeStatus.Active,
            }
        };

        public IActionResult Employees()
        {
            return View(employees);
        }
    }
}
