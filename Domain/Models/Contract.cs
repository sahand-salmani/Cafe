using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Models
{
    public class Contract : BaseEntity
    {
        [Required, MaxLength(255)]
        public string Name { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public int RestaurantId { get; set; }
        public int EmployeeId { get; set; }
        public Restaurant Restaurant { get; set; }
        public Employee Employee { get; set; }
        public ContractType ContractType { get; set; }
        public ICollection<ContractProduct> ContractProducts { get; set; }
        public ICollection<ContractPayment> ContractPayments { get; set; }
    }
}
