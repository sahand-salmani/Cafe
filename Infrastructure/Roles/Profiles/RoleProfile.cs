using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Domain.Users;
using Infrastructure.Roles.ViewModels;

namespace Infrastructure.Roles.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<GetRoleVm, ApplicationRole>().ReverseMap().ForMember(e => e.Users, q => q.MapFrom(t => t.Users));

            CreateMap<ApplicationRole, UpdateRoleVm>();
        }
    }
}
