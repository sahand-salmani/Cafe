using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.ContractPayments.ViewModels
{
    public class UpdateContractPaymentVm : CreateContractPaymentVm
    {
        public int Id { get; set; }
    }
}
