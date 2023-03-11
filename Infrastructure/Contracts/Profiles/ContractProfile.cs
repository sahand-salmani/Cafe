using AutoMapper;
using Domain.Models;
using Infrastructure.Contracts.ViewModels;

namespace Infrastructure.Contracts.Profiles
{
    public class ContractProfile : Profile
    {
        public ContractProfile()
        {
            CreateMap<CreateContractVm, Contract>().ReverseMap();
            CreateMap<UpdateContractVm, Contract>().ReverseMap();

            CreateMap<GetContractVm, Contract>().ReverseMap()
                .ForMember(e => e.Employee, des => des.MapFrom(q => q.Employee))
                .ForMember(e => e.Restaurant, des => des.MapFrom(q => q.Restaurant));
        }
    }
}
