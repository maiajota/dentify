using Microsoft.AspNetCore.Mvc;

namespace Dentify.Web.Controllers;

public class HomeController() : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
