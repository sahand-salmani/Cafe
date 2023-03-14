﻿using AutoMapper;
using Domain.Models;
using Infrastructure.Stants.Commands;
using Infrastructure.Stants.ViewModels;

namespace Infrastructure.Stants.Profiles
{
    public class StantProfile : Profile
    {
        public StantProfile()
        {
            CreateMap<CreateStantCommand, Stant>().ReverseMap();
            CreateMap<CreateStantVm, CreateStantCommand>().ReverseMap();
            CreateMap<UpdateStantVm, Stant>().ReverseMap();
            CreateMap<GetStantVm, Stant>().ReverseMap();
            CreateMap<CreateStantVm, Stant>().ReverseMap();
        }
    }
}
