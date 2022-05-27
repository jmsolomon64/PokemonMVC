using System.Diagnostics;
using System.Text.Json;
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

    public IActionResult Index()
    {
        return View();
    }
    //Action to view Pokedex
    public async Task<IActionResult> Pokedex(int id)
    {
        string route = $"pokemon/{id}";
        HttpResponseMessage response = await _httpClient.GetAsync(route);

        var responseString = await response.Content.ReadAsStringAsync();
        var pokemon = JsonSerializer.Deserialize<PokemonViewModel>(responseString);

        return View(pokemon);
    }

    
}