using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Models
{
    public class Spend : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public DateTime SpentAt { get; set; } = DateTime.Now;
        [MaxLength(2080)]
        public string Note { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
    }
}
