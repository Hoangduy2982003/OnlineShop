using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using OnlineShop.Models.Db;
using System.Diagnostics;

namespace OnlineShop.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly OnlineShopContext _context;
    public HomeController(ILogger<HomeController> logger, OnlineShopContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var banners = _context.Banners.ToList();
        ViewData["banners"] = banners;
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
