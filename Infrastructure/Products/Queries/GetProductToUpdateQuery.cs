using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Products.ViewModels;
using MediatR;

namespace Infrastructure.Products.Queries
{
    public class GetProductToUpdateQuery : IRequest<UpdateProductVm>
    {
        public GetProductToUpdateQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
