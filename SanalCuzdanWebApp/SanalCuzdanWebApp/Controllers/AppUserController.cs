using Microsoft.AspNetCore.Mvc;

namespace SanalCuzdanWebApp.Controllers
{
    public class AppUserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
