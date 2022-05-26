using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PokemonMVC.Models;

namespace PokemonMVC.Controllers;

public class PokemonController : Controller
{
    //Action to view Index
    public IActionResult Index()
    {
        return View();
    }
}