using LordLamington.Heartcore.Content.Models;
using Microsoft.AspNetCore.Mvc;

namespace LordLamington.Heartcore.Content.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(Product model)
        {
            return View(model);
        }
    }
}
