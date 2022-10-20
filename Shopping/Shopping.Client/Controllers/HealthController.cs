using Microsoft.AspNetCore.Mvc;

namespace Shopping.Client.Controllers
{
    public class HealthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
