﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infrastructure.Contracts.ViewModels
{
    public class UpdateContractVm
    {
        public int Id { get; set; }
        [Required, MaxLength(255)]
        public string Name { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public int EmployeeId { get; set; }
        public bool Yearly { get; set; }
        public List<int> ProductsId { get; set; } = new List<int>();
        public SelectList Employees { get; set; }
        public MultiSelectList Products { get; set; }
    }
}
