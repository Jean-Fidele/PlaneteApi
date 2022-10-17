using Microsoft.AspNetCore.Mvc;

namespace PlaneteApi.Controllers.Societes
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
