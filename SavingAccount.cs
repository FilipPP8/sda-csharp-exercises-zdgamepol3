using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    public class SavingAccount : Account
    {
        public decimal interest { get; protected set; }

        public SavingAccount(decimal balance, decimal interest)
            : base (balance)
        {
            this.interest = interest;
        }

        public override decimal TotalBalance
        {
            get { return Balance + interest; } 
        }

        public decimal IncreaseInterest(decimal increase)
        {
            return interest += increase;
        }


    }
}
