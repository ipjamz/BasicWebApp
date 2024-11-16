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

        return products != null ? View(products) : View();
    }
    
    public IActionResult MyOrders()
    {
        var jsonString = System.IO.File.ReadAllText("orders.json");
        var orders = JsonSerializer.Deserialize<List<Order>>(jsonString);

        return orders != null ? View(orders) : View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}