using AutoMapper;
using Domain.Models;
using Infrastructure.Positions.Commands;
using Infrastructure.Positions.ViewModels;

namespace Infrastructure.Positions.Profiles
{
    public class PositionProfile : Profile
    {
        public PositionProfile()
        {
            CreateMap<GetPositionVm, Position>().ReverseMap()
                .ForMember(e => e.Employees, from => from.MapFrom(q => q.Employees));

            CreateMap<CreatePositionCommand, Position>().ReverseMap();
        }
    }
}
