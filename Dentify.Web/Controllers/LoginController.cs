using Microsoft.AspNetCore.Mvc;

namespace Dentify.Web.Controllers;

public class LoginController() : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
