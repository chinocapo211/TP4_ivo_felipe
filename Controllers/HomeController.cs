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
    public IActionResult GuardarIndumentaria(int Equipo, string Medias, string Pantalon, string Remera)
    {
            Medias += ".jpg";
            Pantalon += ".jpg";
            Remera += ".jpg";
            indumentaria a = new indumentaria(Medias,Pantalon,Remera);
            equipos.ingresaIndumentaria(equipos.ListaEquipos[Equipo-1],a);
            ViewBag.dicEquipos = equipos.EquiposIndumentaria;
            return View("Index");
    }
}
