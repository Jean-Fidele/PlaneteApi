using Microsoft.AspNetCore.Mvc;

namespace PlaneteApi.Controllers.Societes
{
    public class SocieteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
