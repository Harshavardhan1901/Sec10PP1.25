using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SubjectController : Controller
    {
        List<Subject> subject = new List<Subject>()
        {
            new Subject { Id = 1, Name = "Mathematics"},
            new Subject {Id = 2, Name = "Cloud Computing"},
            new Subject {Id = 3, Name = "Oops"},
        };
        public IActionResult Index()
        {
            return View(subject);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Subject());
        }

        [HttpPost]
        public IActionResult Create(Subject model)
        {
            if (ModelState.IsValid)
            {
                subject.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}