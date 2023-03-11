using AutoMapper;
using Domain.Models;
using Infrastructure.RestaurantMeetings.ViewModels;

namespace Infrastructure.RestaurantMeetings.Profiles
{
    public class RestaurantMeetingProfile : Profile
    {
        public RestaurantMeetingProfile()
        {
            CreateMap<UpdateRestaurantMeetingVm, RestaurantMeeting>().ReverseMap();
            CreateMap<CreateRestaurantMeetingVm, RestaurantMeeting>().ReverseMap();
            CreateMap<GetRestaurantMeetingVm, RestaurantMeeting>().ReverseMap();

        }
    }
}
