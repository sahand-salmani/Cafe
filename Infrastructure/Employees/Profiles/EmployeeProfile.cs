using AutoMapper;
using Domain.Models;
using Infrastructure.Employees.Commands;
using Infrastructure.Employees.ViewModels;

namespace Infrastructure.Employees.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<GetEmployeeVm, Employee>().ReverseMap()
                .ForMember(e => e.EmployeePayments, des => des.MapFrom(q => q.EmployeePayments));

            CreateMap<CreateEmployeeCommand, Employee>().ReverseMap();
            CreateMap<CreateEmployeeVm, CreateEmployeeCommand>().ReverseMap();
            CreateMap<EditEmployeeVm, Employee>().ReverseMap();
        }
    }
}
