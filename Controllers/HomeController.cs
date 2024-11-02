using Microsoft.AspNetCore.Mvc;
using Medlatec.Models;
namespace Medlatec.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
