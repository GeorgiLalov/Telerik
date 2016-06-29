namespace BankAccounts
{
    using System;

    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer) : base(customer)
        {
        }

        public override void CalcInterestRate(int numberOfMonths)
        {
            if (this.Balance < 1000)
            {
                Console.WriteLine("Deposit Account No Interest Rate for balance under 1000");
                this.InterestRate = 0;
            }
            else
            {
                base.CalcInterestRate(numberOfMonths);
            }
        }

        public void WithDraw(double amount)
        {
            if (this.Balance < 0)
            {
                Console.WriteLine("Cannot withDraw. Balance below zero.");
            }
            else
            {
                double resultBalance = this.Balance - amount;
                if (resultBalance < 0)
                {
                    Console.WriteLine("Cannot withDraw. Balance too low.");
                }
                else
                {
                    this.Balance = resultBalance;
                    Console.WriteLine("WithDraw Successfull. Balance : {0}", this.Balance);
                }
            }
            
        }
    }
}
