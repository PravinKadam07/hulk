using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ad.Models;
using BOL;
using BLL;

namespace ad.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Insert(int id, string name, string place)
    {
        
          Student std = new Student(){id=id,name=name,place=place};
        StManager.InsertStud(std);
        return Redirect("/Home/privacy");
    }

}