using DataAccess.Pagination;
using Domain.Models;
using Infrastructure.PrePayments.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.PrePayments.Queries
{
    public class GetAllPrePaymentsQuery:IRequest<PaginatedList<PrePayment>>
    {
        public GetAllPrePaymentsQuery(int page, int size)
        {
            Page = page;
            Size = size;
        }

        public int Page { get; set; }
        public int Size { get; set; }
    }
}
