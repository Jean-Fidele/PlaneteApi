using Data.Context;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Facade.Societes.Societe
{
    public class GetAll
    {
        public class Request : IRequest<Result>
        {
            public int? PaysId { get; set; }
            public int? FormeJuridiqueId { get; set; }
            public int? CategHotelId { get; set; }
        }

        public class Handler : IRequestHandler<Request, Result>
        {
            private readonly DataContext ctx;
            public Handler(DataContext ctx)
            {
                this.ctx = ctx;
            }

            public async Task<Result> Handle(Request request, CancellationToken cancellationToken)
            {
                var societesReq = ctx.Set<Domain.Entites.Societes.Societe>().AsQueryable();

                if (request.CategHotelId != null)
                {
                    societesReq = societesReq.Where(x => x.CategHotelId == request.CategHotelId);
                }

                if(request.FormeJuridiqueId != null)
                {
                    societesReq = societesReq.Where(x => x.FormeJuridiqueId == request.FormeJuridiqueId);
                }

                var societes = await societesReq.ToListAsync(cancellationToken);

                return new Result { Societes = societes };
            }
        }

        public class Validator : AbstractValidator<Request>
        {
            public Validator()
            {
                RuleFor(x => x.PaysId).Empty();
            }
        }

        public class Result
        {
            public IEnumerable<Domain.Entites.Societes.Societe> Societes { get; set; }
        }
    }

}
