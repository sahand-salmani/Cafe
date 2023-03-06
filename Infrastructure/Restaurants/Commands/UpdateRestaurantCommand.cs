using Infrastructure.Common;
using Infrastructure.Restaurants.ViewModels;
using MediatR;

namespace Infrastructure.Restaurants.Commands
{
    public class UpdateRestaurantCommand : IRequest<OperationResult<GetRestaurantVm>>
    {
        public UpdateRestaurantCommand(int id, GetRestaurantVm model)
        {
            Id = id;
            Model = model;
        }
        public int Id { get; set; }
        public GetRestaurantVm Model { get; set; }
    }
}
