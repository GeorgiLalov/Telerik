namespace BankAccounts
{
    using System;
    using System.Collections.Generic;

    public static class BankAccountsTest
    {
        public static void Test()
        {
            Console.WriteLine("Test Bank Accounts");
            Bank bank = new Bank(
                new List<Account>
                {
                    new DepositAccount(new Customer("Gosho", CustomerType.Company)),
                    new DepositAccount(new Customer("Pesho", CustomerType.Individual)),
                    new LoanAccount(new Customer("Penka", CustomerType.Individual)),
                    new LoanAccount(new Customer("Koliy", CustomerType.Company)),
                    new MortgageAccount(new Customer("Lili", CustomerType.Individual))
                }
            );

            int month = 1;

            foreach (Account account in bank.Accounts)
            {
                account.CalcInterestRate(month);
                month++;
            }

            Console.WriteLine(".....................................");
        }
    }
}
