﻿using AutoMapper;
using Domain.Models;
using Infrastructure.Products.Commands;
using Infrastructure.Products.ViewModels;

namespace Infrastructure.Products.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<Product, GetProductVm>().ForMember(e => e.Contracts, c => c.MapFrom(q => q.Contracts));
            CreateMap<Product, UpdateProductVm>().ReverseMap();
        }
    }
}
