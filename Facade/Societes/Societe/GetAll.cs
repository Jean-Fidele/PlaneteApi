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

        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Domain.Entites.Societes.Societe, SocieteModel>();
                   /* .ForMember(x => x.SocieteId, opt => opt.MapFrom(x => x.SocieteId))
                    .ForMember(x => x.Nom, opt => opt.MapFrom(x => x.Nom))
                    .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email));*/
            }
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
                var total = await societesReq.CountAsync(cancellationToken);
                var societeModels = _mapper.Map<List<SocieteModel>>(societes);

                return new Result { TotalRows = total, societeModels = societeModels };
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
            public int TotalRows { get; set; }
            public IEnumerable<SocieteModel> societeModels { get; set; } = new List<SocieteModel>();
        }

        public class SocieteModel
        {
            public int SocieteId { get; set; }
            public int PaysId { get; set; }
            public int FormeJuridiqueId { get; set; }
            public int? CategHotelId { get; set; }
            public string Nom { get; set; }
            public decimal? Capital { get; set; }
            public string Adresse { get; set; }
            public string AdressCompl { get; set; }
            public string Region { get; set; }
            public int? RegionCode { get; set; }
            public string Tel { get; set; }
            public string Fax { get; set; }
            public string Website { get; set; }
            public string Email { get; set; }
            public string Stat { get; set; }
            public string NIF { get; set; }
            public string Logo { get; set; }
            public decimal? Longitude { get; set; }
            public decimal? Latitude { get; set; }
            public string ChampLibre { get; set; }
            public string ChampLibre2 { get; set; }
            public string ChampLibre3 { get; set; }
        } 
    }
}