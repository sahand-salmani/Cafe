using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using DataAccess.Constants;

namespace Infrastructure.PrePayments.ViewModels
{
    public class CreatePrePaymentVm
    {
        public int EmployeeId { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; } = DateTime.Now;
        public decimal Amount { get; set; }
        [MaxLength(2080)]
        public string Note { get; set; }
    }
}
