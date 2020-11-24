using LordLamington.Heartcore.Content.Models;
using Microsoft.AspNetCore.Mvc;

namespace LordLamington.Heartcore.Content.Controllers
{
    public class ContentPageController : Controller
    {
        public IActionResult Index(ContentPage model)
        {
            return View(model);
        }
    }
}
