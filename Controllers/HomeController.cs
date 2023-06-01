using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP5_Kalinscky_Aboudara_Garbarino.Models;

namespace TP5_Kalinscky_Aboudara_Garbarino.Controllers;

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
    public IActionResult Tutorial(){
        return View();
    }

    public IActionResult Comenzar(){
            return View("Habitacion"+Escape.GetEstadoJuego().ToString());
        }
    public IActionResult Creditos(){
        return View();
    }
    public IActionResult Habitacion(int sala, string clave){
        const int maxSala = 4;
        if(sala==Escape.GetEstadoJuego()){
            if(!Escape.ResolverSala(sala,clave)) 
                ViewBag.Error = "Clave incorrecta";
        }
        if(Escape.GetEstadoJuego() > maxSala)  
            return View("Victoria");
        return View("Habitacion"+Escape.GetEstadoJuego().ToString());
        }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
