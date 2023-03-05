using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Infrastructure.Common;
using Infrastructure.Restaurants.ViewModels;
using MediatR;

namespace Infrastructure.Restaurants.Commands
{
    public class UpdateRestaurantCommand : IRequest<OperationResult<GetRestaurantVm>>
    {
        public UpdateRestaurantVm UpdateRestaurantVm { get; set; }
    }
}
