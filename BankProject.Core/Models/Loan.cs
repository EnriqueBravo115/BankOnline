using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Core.Models
{
    class Loan
    {
        private long id { get; set; }
        private long customerId { get; set; }
        private DateTime dueDate { get; set; }
        private long principalLoanAmount { get; set; }
    }
}
