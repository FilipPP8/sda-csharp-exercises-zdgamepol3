using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(5000);

            SavingAccount account2 = new SavingAccount(10000, 200);

            account1.IncreaseBalance(3000);

            Console.WriteLine(account1.TotalBalance);

            account2.IncreaseBalance(4000);

            account2.IncreaseInterest(300);

            Console.WriteLine(account2.TotalBalance);

            Account[] accounts = { account1, account2 };

            Bank bank = new Bank();

            foreach (Account i in accounts)
            {
                bank.AddAccount(i);
            }

            bank.GetValue();
        }
    }
}
