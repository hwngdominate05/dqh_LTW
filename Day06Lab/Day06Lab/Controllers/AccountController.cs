using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using System.Text.RegularExpressions;
using Day06Lab.Models;

namespace Day06Lab.Controllers
{
    public class AccountController : Controller
    {
        
        public ActionResult Index()
        {
            List<Account> accounts = new List<Account>();
            return View(accounts);
        }


        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult Create()
        {
            Account model = new Account();
            return View(model);
        }


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


        public ActionResult Edit(int id)
        {
            return View();
        }


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


        public ActionResult Delete(int id)
        {
            return View();
        }


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

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyPhone(string phone)
        {
            Regex _isPhone = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (!_isPhone.IsMatch(phone))
            {
                ;
                return Json($"Số điện thoại {phone} không đúng định dạng, VD:0986421127 hoặc 098.421.1127");

            }
            return Json(true);
        }
    }
}

