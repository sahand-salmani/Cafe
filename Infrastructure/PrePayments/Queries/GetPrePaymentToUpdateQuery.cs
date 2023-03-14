using Infrastructure.PrePayments.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.PrePayments.Queries
{
    public class GetPrePaymentToUpdateQuery:IRequest<EditPrePaymentVm>
    {
        public GetPrePaymentToUpdateQuery(int id)
        {
            Id =id;
        }
        public int Id { get; set; }
    }
}
