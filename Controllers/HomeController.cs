using Microsoft.AspNetCore.Mvc;

namespace PortFolioII.controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View("index");
    }
    [HttpGet("projects")]
    public IActionResult Project()
    {
        return View("projects");
    }
    [HttpGet("contact")]
    public IActionResult Contact()
    {
        return View("contact");
    }
}