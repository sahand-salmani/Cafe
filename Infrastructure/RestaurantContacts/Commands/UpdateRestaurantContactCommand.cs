using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Common;
using Infrastructure.RestaurantContacts.ViewModels;
using MediatR;

namespace Infrastructure.RestaurantContacts.Commands
{
    public class UpdateRestaurantContactCommand : IRequest<OperationResult<int>>
    {
        public UpdateRestaurantContactCommand(UpdateRestaurantContactVm model)
        {
            Model = model;
        }
        public UpdateRestaurantContactVm Model { get; set; }
    }
}
