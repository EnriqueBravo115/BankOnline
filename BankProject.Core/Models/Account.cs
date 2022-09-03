using BankProject.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Core.Models
{
    class Account
    {
        private long Id { get; set; }
        private long CustomerId { get; set; }
        private string? Description { get; set; }
        private decimal CurrentBalance { get; set; }
        private AccountCurrencyType CurrencyType { get; set; }
        private AccountActivityType AccountType { get; set; }
        private DateTime TransactionDate { get; set; }
        
    }
}
