using AutoMapper;
using Domain.Models;
using Infrastructure.ContractPayments.ViewModels;

namespace Infrastructure.ContractPayments.Profiles
{
    public class ContractPaymentProfile : Profile
    {
        public ContractPaymentProfile()
        {
            CreateMap<ContractPayment, CreateContractPaymentVm>().ReverseMap();
            CreateMap<UpdateContractPaymentVm, ContractPayment>().ReverseMap();
        }
    }
}
