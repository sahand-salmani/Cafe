using System;
using System.Collections.Generic;
using System.Text;
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
        }
    }
}
