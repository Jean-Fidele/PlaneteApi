using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace PlaneteApi.Controllers.Societes
{
    [ApiController]
    [Route("[controller]")]
    public class SocieteController : ControllerBase
    {
        protected readonly IMediator Mediator;
        public SocieteController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            var res = await Mediator.Send(new Facade.Societes.Societe
                                    .GetAll.Request { Username = "Fidele" });

            if(res.Societes.Count() <= 0)
            {
                return NotFound("The element is not find in the list.");
            }

            return Ok(res);
        }
    }
}
