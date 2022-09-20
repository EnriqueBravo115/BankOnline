using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Core.Models
{
    class CreditCard
    {
        private long id { get; set; }
        private long customerId { get; set; }
        private long totalLimit { get; set; }
        private DateTime expireDate { get; set; }
        private DateTime cancelDate { get; set; }
    }
}
