using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AMS23_FIRST_MVC.Models;

namespace AMS23_FIRST_MVC.Controllers;

public class CategoryController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public CategoryController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Category()
    {
       
        
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
