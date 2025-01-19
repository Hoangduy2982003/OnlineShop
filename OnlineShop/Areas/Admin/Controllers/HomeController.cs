using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Areas.Admin.Controllers;
public class HomeController : Controller
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public IActionResult Index()
    {
        return View();
    }
}
