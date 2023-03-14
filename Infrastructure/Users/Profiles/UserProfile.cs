using AutoMapper;
using Domain.Users;
using Infrastructure.Users.ViewModels;

namespace Infrastructure.Users.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<GetUserVm, ApplicationUser>().ReverseMap().ForMember(e => e.UserRoles, des => des.MapFrom(q => q.Roles));
        }
    }
}
