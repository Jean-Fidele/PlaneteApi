using Domain.Entites.Societes;
using Facade.Societes.Societe;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;

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
        public async Task<IActionResult> Get([FromQuery] GetAll.Request request)
        {
            var res = await Mediator.Send(new GetAll.Request { 
                                                    PaysId = request.PaysId, 
                                                    CategHotelId = request.CategHotelId, 
                                                    FormeJuridiqueId = request.FormeJuridiqueId 
                                         });
            
            if(res.Societes.Count() <= 0)
            {
                return NotFound("The element is not find in the list.");
            }

            return Ok(res.Societes); //new GetAll.Result { Societes = res.Societes }
        }
    }
}
