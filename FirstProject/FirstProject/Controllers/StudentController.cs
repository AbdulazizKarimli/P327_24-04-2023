using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        List<Student> students = new()
        {
            new Student { Id = 1, Name = "Mehemmed", Age = 27 },
            new Student { Id = 2, Name = "Shahin", Age = 18 },
            new Student { Id = 3, Name = "Huseyn", Age = 21 },
            new Student { Id = 4, Name = "Orxan", Age = 26 }
        };

        //ViewBag.Students = students;
        //ViewData["Students"] = students;
        //TempData["Students"] = students;

        //string name = "Asiman";
        //ViewBag.Name = name;
        //ViewData["Name"] = name;
        //TempData["Name"] = name;

        return View(students);
        //return RedirectToAction("Test");
    }

    public IActionResult Test()
    {
        return View();
    }

    public IActionResult Detail(int? id)
    {
        ViewBag.Id = id;

        return View();
    }
}