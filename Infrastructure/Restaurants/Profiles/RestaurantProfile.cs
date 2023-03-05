using AutoMapper;
using Domain.Models;
using Infrastructure.Interns.Commands;
using Infrastructure.Restaurants.ViewModels;

namespace Infrastructure.Restaurants.Profiles
{
    public class RestaurantProfile : Profile
    {
        public RestaurantProfile()
        {
            CreateMap<CreateInternCommand, Restaurant>().ReverseMap();
            CreateMap<GetRestaurantVm, Restaurant>().ReverseMap();
        }
    }
}
