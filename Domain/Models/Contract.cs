using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Models
{
    public class Contract : BaseEntity
    {
        [Required, DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }
        public bool IsPaid { get; set; } = false;
        public int RestaurantId { get; set; }
        public int EmployeeId { get; set; }
        public Restaurant Restaurant { get; set; }
        public Employee Employee { get; set; }
        public ICollection<ContractProduct> ContractProducts { get; set; }
    }
}
