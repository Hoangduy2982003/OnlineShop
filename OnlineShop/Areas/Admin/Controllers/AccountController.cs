using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Areas.Admin.Controllers;
public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
