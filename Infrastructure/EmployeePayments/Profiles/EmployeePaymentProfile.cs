using AutoMapper;
using Domain.Models;
using Infrastructure.EmployeePayments.Commands;
using Infrastructure.EmployeePayments.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EmployeePayments.Profiles
{
    public class EmployeePaymentProfile : Profile
    {
        public EmployeePaymentProfile()
        {
            CreateMap<CreateEmployeePaymentCommand, EmployeePayment>().ReverseMap();
            CreateMap<CreateEmployeePaymentVm, CreateEmployeePaymentCommand>().ReverseMap();
            CreateMap<CreateEmployeePaymentVm, EmployeePayment>().ReverseMap();
            CreateMap<UpdateEmployeePaymentVm, EmployeePayment>().ReverseMap();
            CreateMap<GetEmployeePaymentVm, EmployeePayment>().ReverseMap();

        }
    }
}
