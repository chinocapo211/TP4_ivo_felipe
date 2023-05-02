using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Index()
    {
        ViewBag.EquiposIndumentaria = equipos.ingresaIndumentaria();
        return View();
    }
}
