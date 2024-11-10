using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    // Acción para la vista de Matemáticas
    public IActionResult Matematicas()
    {
        ViewData["Message"] = "Esta es la página de Matemáticas.";
        return View();
    }

    // Acción para la vista de Arquitectura
    public IActionResult Arquitectura()
    {
        ViewData["Message"] = "Esta es la página de Arquitectura.";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
