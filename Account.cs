using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    public class Account
    {
        public decimal Balance { get; protected set; }

        public Account(decimal balance)
        {
            this.Balance = balance;
        }

        public decimal IncreaseBalance(decimal value)
        {
            return Balance += value;
        }

        public virtual decimal TotalBalance
        {
            get { return Balance; }
        }

    }
}