using Microsoft.AspNetCore.Mvc;
using Day13Lab.Data;
using Day13Lab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day13Lab.Controllers
{
    public class LearnerController : Controller
    {
        private SchoolContext db;
        public LearnerController(SchoolContext context)
        {
            db = context;
        }

        public IActionResult Create()
        {
            var majors = new List<SelectListItem>();
            foreach(var item in db.Majors)
            {
                majors.Add(new SelectListItem
                {
                    Text = item.MajorName,
                    Value = item.MajorID.ToString()
                });

            }
            ViewBag.MajorsID = majors;
            ViewBag.MajorID = new SelectList(db.Majors, "MajorID", "MajorName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Learner learner)
        {
            if (ModelState.IsValid)
            {
                db.Learners.Add(learner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MajorID = new SelectList(db.Majors, "MajorID", "MajorName", learner.MajorID);
            return View();
        }
        public IActionResult Index()
        {
            var learners = db.Learners.Include(l => l.Major).ToList();
            return View(learners);
        }


    }
}
