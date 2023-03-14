using Infrastructure.EmployeePayments.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EmployeePayments.Queries
{
    public class GetEmployeePaymentByIdQuery : IRequest<GetEmployeePaymentVm>
    {
        public GetEmployeePaymentByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
