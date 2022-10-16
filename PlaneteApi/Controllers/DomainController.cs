using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PlaneteApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DomainController : ControllerBase
    {
        public async Task<ActionResult> Index()
        {
            return Ok();
        }

        public async Task<ActionResult> Details(int id)
        {
            return Ok();
        }

        public async Task<ActionResult> Create()
        {
            return Ok();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            return Ok();
        }

        public async Task<ActionResult> Edit(int id)
        {
            return Ok();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            return Ok();
        }

        public async Task<ActionResult> Delete(int id)
        {
            return Ok();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            return Ok();
        }
    }
}
