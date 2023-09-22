using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        List<Student> student = new List<Student>()
        {
            new Student { Id = 1, Name = "Samuel", Class = "8A", Age = 16, Address = "LA"},
            new Student { Id = 2, Name = "Anil", Class = "8B", Age = 17, Address = "Hollywood Hills"},
            new Student { Id = 3, Name = "Kowshik", Class = "8C", Age = 16, Address = "ABC Street,Pune"},
        };
        public IActionResult Index()
        {
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                student.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
