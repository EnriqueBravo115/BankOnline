using BankProject.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Core.Entities
{
    class Account
    {
        private long id { get; set; }
        private long customerId { get; set; }
        private string? description { get; set; }
        private decimal currentBalance { get; set; }
        private AccountCurrencyType currencyType { get; set; }
        private AccountActivityType accountType { get; set; }
        private DateTime transactionDate { get; set; }
        
    }
}
