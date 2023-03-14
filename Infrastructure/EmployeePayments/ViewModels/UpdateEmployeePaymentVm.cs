using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

namespace Infrastructure.EmployeePayments.ViewModels
{
    public class UpdateEmployeePaymentVm : CreateEmployeePaymentVm
    {
        public int Id { get; set; }
    }
}
