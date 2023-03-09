using AutoMapper;
using Domain.Models;
using Infrastructure.RestaurantContacts.ViewModels;

namespace Infrastructure.RestaurantContacts.Profiles
{
    public class RestaurantContactProfile : Profile
    {
        public RestaurantContactProfile()
        {
            CreateMap<CreateRestaurantContactVm, RestaurantContact>().ReverseMap();
            CreateMap<GetRestaurantContactVm, RestaurantContact>().ReverseMap();
        }
    }
}
