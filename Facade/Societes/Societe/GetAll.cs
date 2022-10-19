using AutoMapper;
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
            private readonly DataContext _ctx;
            private readonly IMapper _mapper;
            public Handler(DataContext ctx, IMapper mapper)
            {
                this._ctx = ctx;
                this._mapper = mapper;
            }

            public async Task<Result> Handle(Request request, CancellationToken cancellationToken)
            {
                var societesReq = _ctx.Set<Domain.Entites.Societes.Societe>().AsQueryable();

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

/*
public UserProfile()
{
    CreateMap<User, UserViewModel>();
}
public UserProfile()
{
    CreateMap<User, UserViewModel>()
        .ForMember(dest =>
            dest.FName,
            opt => opt.MapFrom(src => src.FirstName))
        .ForMember(dest =>
            dest.LName,
            opt => opt.MapFrom(src => src.LastName))
}
UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);

public UserProfile()
{
    CreateMap<User, UserViewModel>()
        .ForMember(dest =>
            dest.FName,
            opt => opt.MapFrom(src => src.FirstName))
        .ForMember(dest =>
            dest.LName,
            opt => opt.MapFrom(src => src.LastName))
        .ReverseMap();
}
var mappedUser = _mapper.Map<User>(userViewModel);


public IEnumerable<WeatherForecastViewModel> Get()
{
    var weatherForecasts = Enumerable.Range(1, 5)
        .Select(index =>
            new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
        .ToList();

    return _mapper.Map<List<WeatherForecastViewModel>>(weatherForecasts);
}

*/
