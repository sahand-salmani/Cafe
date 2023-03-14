using Domain.Models;
using Infrastructure.Common;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Infrastructure.PrePayments.ViewModels;

namespace Infrastructure.PrePayments.Commands
{
    public class CreatePrePaymentCommand : IRequest<OperationResult<int>>
    {
        public CreatePrePaymentCommand(CreatePrePaymentVm model)
        {
            Model = model;
        }
        public CreatePrePaymentVm Model { get; set; }
    }
}
