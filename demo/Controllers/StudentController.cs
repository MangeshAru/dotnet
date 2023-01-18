using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using demo.Models;
using DAL;
using BOL;

namespace demo.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public StudentController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    //  public IActionResult Insert(int id , )
    // {
    //     return View();
    // }


    public IActionResult InsertData(int id , string? name , int marks)
    {
        Student std = new Student(){
             Id= id,
             Name=name,
             Marks= marks
        };
        DBManager.insertStdData(std);
        return Redirect("/Home/Index");
    }
    public IActionResult GetAllStd(){
        List<Student> getData = DBManager.getAll();
        ViewData["GetData"] = getData ;
        return View();

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
