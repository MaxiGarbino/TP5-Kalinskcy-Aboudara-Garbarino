﻿using System.Diagnostics;
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
            return View();
        }
    public IActionResult Habitacion(int sala, string clave){
            return View();
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
