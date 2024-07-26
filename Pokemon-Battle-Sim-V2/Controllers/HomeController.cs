using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pokemon_Battle_Sim_V2.Models;

namespace Pokemon_Battle_Sim_V2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly PokeAPI _pokeApi;

    public HomeController(ILogger<HomeController> logger, PokeAPI pokeApi)
    {
        _logger = logger;
        _pokeApi = pokeApi;
    }

    public async Task<IActionResult> Index()
    {
        //var call = new PokeAPI();

        var callName = Request.Form["pokeName"].ToString();
        var callLevel = int.Parse(Request.Form["pokeLevel"]);
        var callNature = Request.Form["pokeNature"].ToString();

        var result = await _pokeApi.GetBasicInfo(callName, callLevel, callNature);
        
        return View(result);
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

