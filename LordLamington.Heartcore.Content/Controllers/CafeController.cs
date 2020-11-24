using LordLamington.Heartcore.Content.Models;
using Microsoft.AspNetCore.Mvc;

namespace LordLamington.Heartcore.Content.Controllers
{
    public class CafeController : Controller
    {
        public IActionResult Index(Cafe model)
        {
            return View(model);
        }
    }
}
