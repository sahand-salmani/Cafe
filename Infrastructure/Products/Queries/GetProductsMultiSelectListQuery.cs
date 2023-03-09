using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infrastructure.Products.Queries
{
    public class GetProductsMultiSelectListQuery : IRequest<MultiSelectList>
    {
        public GetProductsMultiSelectListQuery(List<int> products)
        {
            Products = products ?? new List<int>();
        }
        public List<int> Products { get; set; }
    }
}
