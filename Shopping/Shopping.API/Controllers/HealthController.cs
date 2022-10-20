using Microsoft.AspNetCore.Mvc;

namespace Shopping.API.Controllers
{
    public class HealthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
