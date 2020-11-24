using LordLamington.Heartcore.Content.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LordLamington.Heartcore.Content.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index(ErrorViewModel model)
        {
            return View(model);
        }
    }
}
