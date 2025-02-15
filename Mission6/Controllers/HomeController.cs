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
   

    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Form()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Form(Movie response)
    {
        if (ModelState.IsValid) // Check if input is valid
        {
            _context.Movies.Add(response);
            _context.SaveChanges(); // Commit to DB

            return View("Confirmation", response);
        }
        return View("Confirmation", response);
    }

    public IActionResult GetToKnow()
    {
        return View();
    }
}