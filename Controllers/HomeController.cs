using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using BasicWebApp.Models;

namespace BasicWebApp.Controllers;

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

    public IActionResult Store()
    {
        var jsonString = System.IO.File.ReadAllText("products.json");
        var products = JsonSerializer.Deserialize<List<Product>>(jsonString);

        if (products != null)
        {
            return View(products);
        }
        return View();
    }
    
    public IActionResult MyOrders()
    {
        var jsonString = System.IO.File.ReadAllText("orders.json");
        var orders = JsonSerializer.Deserialize<List<Order>>(jsonString);

        if (orders != null)
        {
            return View(orders);
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}