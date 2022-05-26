using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PokemonMVC.Models;

namespace PokemonMVC.Controllers;

public class PokemonController : Controller
{
    //instance of http client
    private readonly  HttpClient _httpClient;
    public PokemonController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("pokeapi"); //sets client equal to pokeapi in program.cs
    }
    //Action to view Index
    public IActionResult Index()
    {
        return View();
    }
}