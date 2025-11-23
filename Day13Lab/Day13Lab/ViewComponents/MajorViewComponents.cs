using Microsoft.AspNetCore.Mvc;
using Day13Lab.Models;
using Day13Lab.Data;

namespace Day13Lab.ViewComponents
{
    public class MajorViewComponents : ViewComponent
    {
        SchoolContext db;
        List<Major> majors;
        public MajorViewComponents(SchoolContext context)
        {
            db = context;
            majors = db.Majors.ToList();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderMajor", majors);
        }
    }
}
