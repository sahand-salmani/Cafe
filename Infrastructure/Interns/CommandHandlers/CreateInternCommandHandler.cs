using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Constants;
using DataAccess.Database;
using DataAccess.Persistence;
using Domain.Models;
using Infrastructure.Common;
using Infrastructure.Interns.Commands;
using Infrastructure.Interns.ViewModels;
using MediatR;

namespace Infrastructure.Interns.CommandHandlers
{
    public class CreateInternCommandHandler : IRequestHandler<CreateInternCommand, OperationResult<GetInternVm>>
    {
        private readonly DatabaseContext _dbContext;
        private readonly IPersistence _persistence;
        private readonly IMapper _mapper;

        public CreateInternCommandHandler(DatabaseContext dbContext, 
                                          IPersistence persistence,
                                          IMapper mapper)
        {
            _dbContext = dbContext;
            _persistence = persistence;
            _mapper = mapper;
        }


        public async Task<OperationResult<GetInternVm>> Handle(CreateInternCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<GetInternVm>();

            //var intern = new Intern()
            //{
            //    Name = request.Name,
            //    PhoneNumber = request.PhoneNumber,
            //    StartsAt = request.StartsAt,
            //    Email = request.Email,
            //    Address = request.Address,
            //    FinishedAt = request.FinishedAt,
            //    University = request.University,
            //};

            var aaa = _mapper.Map<Intern>(request);

            _dbContext.Interns.Add(aaa);

            var persistence = await _persistence.SaveChangesAsync();

            if (persistence > 0)
            {
                result.Entity = null;
                return result;
            }

            return result.AddError(ErrorMessages.CouldNotAddToDatabase);
        }
    }
}
