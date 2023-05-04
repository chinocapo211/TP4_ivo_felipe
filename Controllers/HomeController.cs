using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.dicEquipos = equipos.EquiposIndumentaria;
        return View();
    }
    public IActionResult SelectIndumentaria()
    {
        ViewBag.ListaEquipos = equipos.ListaEquipos;
        ViewBag.ListaMedias = equipos.ListaMedias;
        ViewBag.ListaPantalones = equipos.ListaPantalones;
        ViewBag.ListaRemeras = equipos.ListaRemeras;
        return View();
    }
    public IActionResult GuardarIndumentaria(string Equipo, string Media, string Pantalon, string Remera)
    {
        if(Equipo == string.Empty || Media == string.Empty || Pantalon == string.Empty || Remera == string.Empty)
        {
            ViewBag.Error = "m";
            return View("SelectIndumentaria");
        }
        else
        {
            indumentaria a = new indumentaria(Media,Pantalon,Remera);
            equipos.EquiposIndumentaria.Add(Equipo,a);
            return View("Index");
        }
    }
}
