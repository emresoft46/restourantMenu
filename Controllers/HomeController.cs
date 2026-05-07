using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using restoranrSites_backend.Models;

namespace restoranrSites_backend.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Rezerve()
    {
        return View();
    }

    public IActionResult subelerimiz()
    {
        return View();
    }


    public IActionResult sss()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
