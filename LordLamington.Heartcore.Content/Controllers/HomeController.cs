using LordLamington.Heartcore.Content.Models;
using Microsoft.AspNetCore.Mvc;

namespace LordLamington.Heartcore.Content.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(Home model)
        {
            return View(model);
        }
    }
}
