using Microsoft.AspNetCore.Mvc;
using WebAppDeployStudent.Models;


namespace WebApDeployStudent.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teacher = new List<Teacher>()
        {
            new Teacher { Id = 1, Name = "Mr.Ayer", TeachingSubject = "Physics"},
            new Teacher { Id = 2, Name = "Mr.Sujata", TeachingSubject = "Englisg"},
            new Teacher { Id = 3, Name = "Mr.Krisha", TeachingSubject = "Maths"},
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
