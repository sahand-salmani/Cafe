using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Pagination;
using Domain.Models;
using Infrastructure.Interns.ViewModels;
using MediatR;

namespace Infrastructure.Interns.Queries
{
    public class GetAllInternsQuery : IRequest<PaginatedList<Intern>>, IRequest<PaginatedList<GetInternVm>>
    {
        public int Page { get; set; }
        public int Size { get; set; }

        private GetAllInternsQuery(int page, int size)
        {
            Page = page;
            Size = size;
        }
        public static GetAllInternsQuery GetAll(int page, int size) => new GetAllInternsQuery(page, size);
    }
}
