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
            public string? Username { get; set; }
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
                var societes = await ctx.Set<Domain.Entites.Societes.Societe>()
                                     .ToListAsync(cancellationToken);

                return new Result { Societes = societes };
            }
        }

        public class Validator : AbstractValidator<Request>
        {
            public Validator()
            {
                RuleFor(x => x.Username).Empty();
            }
        }

        public class Result
        {
            public IEnumerable<Domain.Entites.Societes.Societe> Societes { get; set; }
        }
    }

}
