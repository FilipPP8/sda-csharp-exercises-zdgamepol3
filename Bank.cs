using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    public class Bank
    {
        List<Account> accounts = new List<Account>();

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public void GetValue()
        {
            decimal sum = 0;
            foreach (Account a in accounts)
            {
                sum += a.TotalBalance;
            }

            Console.WriteLine("Łączna wartość wynosi: " + sum);
        }
    }
}
