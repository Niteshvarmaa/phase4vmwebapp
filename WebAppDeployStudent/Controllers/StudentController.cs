using Microsoft.AspNetCore.Mvc;
using WebAppDeployStudent.Models;


namespace WebAppDeployStudent.Controllers
{
    public class StudentController : Controller
    {
        List<Student> student = new List<Student>()
        {
            new Student { Id = 1, Name = "Sami", Class = "7A", Age = 15, Address = "road1"},
            new Student { Id = 2, Name = "Ram", Class = "5B", Age = 16, Address = "road2"},
            new Student { Id = 3, Name = "Kumar", Class = "5C", Age = 17, Address = "road3 "},
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
