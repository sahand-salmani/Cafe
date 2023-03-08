using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Contracts.ViewModels
{
    class CreateContractVm
    {
        [Required,DataType(DataType.DateTime)]
        public DateTime StarTime { get; set; }
        [Required,DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }
        public bool IsPaid { get; set; }
        public int RestaurantId { get; set; }
        public int EmployeeId { get; set; }

    }
}
