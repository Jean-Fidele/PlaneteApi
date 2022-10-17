using Microsoft.AspNetCore.Mvc;

namespace PlaneteApi.Controllers.Societes
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
