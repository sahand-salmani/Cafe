using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Models;
using Infrastructure.Restaurants.ViewModels;

namespace Infrastructure.Contracts.ViewModels
{
    public class GetContractVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public bool IsPaid { get; set; } = false;
        public GetRestaurantVm Restaurant { get; set; }
        public Employee Employee { get; set; }
        public List<ContractProduct> ContractProducts { get; set; } = new List<ContractProduct>();
        public string ContractType { get; set; }

    }
}
