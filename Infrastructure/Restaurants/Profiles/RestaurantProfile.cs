using AutoMapper;
using Domain.Models;
using Infrastructure.Restaurants.Commands;
using Infrastructure.Restaurants.ViewModels;

namespace Infrastructure.Restaurants.Profiles
{
    public class RestaurantProfile : Profile
    {
        public RestaurantProfile()
        {
            CreateMap<CreateRestaurantCommand, Restaurant>().ReverseMap();
            CreateMap<GetRestaurantVm, Restaurant>().ReverseMap();
        }
    }
}
