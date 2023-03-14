using DataAccess.Pagination;
using Domain.Models;
using Infrastructure.Common;
using Infrastructure.Employees.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EmployeePayments.Queries
{
    public class GetAllEmployeePaymentsQuery :IRequest<PaginatedList<EmployeePayment>>
    {
        public int Page { get; set; }
        public int Size { get; set; }

        public GetAllEmployeePaymentsQuery(int page,int size)
        {
            Page = page;
            Size = size;
        }
    }
}
