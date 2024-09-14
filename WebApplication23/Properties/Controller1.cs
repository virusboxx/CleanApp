using Microsoft.AspNetCore.Mvc;

namespace WebApplication23.Properties;

public class Controller1 : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}