using LordLamington.Heartcore.Content.Models;
using Microsoft.AspNetCore.Mvc;

namespace LordLamington.Heartcore.Content.Controllers
{
    public class CafeCollectionController : Controller
    {
        public IActionResult Index(CafeCollection model)
        {
            return View(model);
        }
    }
}
