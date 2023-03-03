using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Models
{
    public class ContractProduct : BaseEntity
    {
        public int ContractId { get; set; }
        public int ProductId { get; set; }
        public bool IsMonthly { get; set; }

        public Contract Contract { get; set; }
        public Product Product { get; set; }
    }
}
