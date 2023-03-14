using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Infrastructure.Common;

namespace Infrastructure.EmployeePayments.ViewModels
{
    public class CreateEmployeePaymentVm
    {
        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        [DataType(DataType.Date)] public DateTime PaidTime { get; set; } = DateTime.Now;
        public int EmployeeId { get; set; }
    }
}
