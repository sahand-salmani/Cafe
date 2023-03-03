using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Constants;
using DataAccess.Database;
using Infrastructure.Common;
using Infrastructure.Interns.Queries;
using Infrastructure.Interns.ViewModels;
using MediatR;

namespace Infrastructure.Interns.QueryHandlers
{
    public class GetInternByIdQueryHandler : IRequestHandler<GetInternByIdQuery, OperationResult<GetInternVm>>
    {
        private readonly IEntity _entity;
        private readonly IMapper _mapper;

        public GetInternByIdQueryHandler(IEntity entity,
                                         IMapper mapper)
        {
            _entity = entity;
            _mapper = mapper;
        }
        public async Task<OperationResult<GetInternVm>> Handle(GetInternByIdQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<GetInternVm>();

            var intern = await _entity.Interns.FindAsync(request.Id, cancellationToken);

            if (intern is null)
            {
                return result.AddError(ErrorMessages.EntityNotFound);
            }

            result.Entity = _mapper.Map<GetInternVm>(intern);


            return result;
        }
    }
}
