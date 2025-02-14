using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;

namespace Mission6.Controllers;

public class HomeController : Controller
{
    
    private MovieFormContext _context;
    
    public HomeController(MovieFormContext context)
    {
        _context = context;
    }
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Form()
    {
        return View();
    }
    public IActionResult GetToKnow()
    {
        return View();
    }

    [HttpPost]
    public IActionResult MovieForm(Movie response)
    {
        _context.Movies.Add(response);
        _context.SaveChanges(); // Commits the changes to the Database
        
        return View("Confirmation", response);
    }

    
}