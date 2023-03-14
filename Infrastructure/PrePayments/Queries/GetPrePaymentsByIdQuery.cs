using DataAccess.Pagination;
using Domain.Models;
using Infrastructure.PrePayments.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.PrePayments.Queries
{
    public class GetPrePaymentsByIdQuery:IRequest<GetPrePaymentVm>
    {
        public GetPrePaymentsByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
       
    }
}
