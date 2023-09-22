using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TeacherController : Controller
    {
      
            List<Teacher> teacher = new List<Teacher>()
        {
            new Teacher { Id = 1, Name = "Sameer", TeachingSubject = "Mathematics"},
            new Teacher { Id = 2, Name = "Salman", TeachingSubject = "Cloud Computing"},
            new Teacher { Id = 3, Name = "Abhishek", TeachingSubject = "Oops"},
        };
            public IActionResult Index()
            {
                return View(teacher);
            }

            [HttpGet]
            public IActionResult Create()
            {
                return View(new Teacher());
            }

            [HttpPost]
            public IActionResult Create(Teacher model)
            {
                if (ModelState.IsValid)
                {
                    teacher.Add(model);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
        }
    }

