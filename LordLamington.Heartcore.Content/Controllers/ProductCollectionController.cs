using LordLamington.Heartcore.Content.Models;
using Microsoft.AspNetCore.Mvc;

namespace LordLamington.Heartcore.Content.Controllers
{
    public class ProductCollectionController : Controller
    {
        public IActionResult Index(ProductCollection model)
        {
            return View(model);
        }
    }
}
