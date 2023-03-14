using AutoMapper;
using Domain.Models;
using Infrastructure.Spends.Commands;
using Infrastructure.Spends.ViewModels;

namespace Infrastructure.Spends.Profiles
{
    public class SpendProfile : Profile
    {
        public SpendProfile()
        {
            CreateMap<GetSpendVm, Spend>().ReverseMap();
            CreateMap<CreateSpendVm, CreateSpendCommand>().ReverseMap();
            CreateMap<CreateSpendVm, Spend>().ReverseMap();
            CreateMap<EditSpendVm, Spend>().ReverseMap();
        }
    }
}
