namespace BankAccounts
{
    using System;

    public abstract class Account
    {
        public Customer Customer { get; protected set; }
        public double Balance { get; protected set; }
        public double InterestRate { get; protected set; }

        public Account(Customer customer)
        {
            this.Customer = customer;
            this.Balance = 0;
            this.InterestRate = 0;
        }

        public virtual void CalcInterestRate(int numberOfMonths)
        {
            if (this.InterestRate == 0)
            {
                this.InterestRate = 1;
            }
            this.InterestRate *= numberOfMonths;

            Console.WriteLine("Successfull Calc. Interest Rate is : {0}", this.InterestRate);
        }

        public void Deposit(double amount)
        {
            if (amount < 0 )
            {
                Console.WriteLine("Amount less than zero!");
            }
            else
            {
                this.Balance += amount;
                Console.WriteLine("Successfull Deposit. Balance is : {0}", this.Balance);
            }
            
        }

        public override string ToString()
        {
            return $"{this.Customer.ToString()}\t{this.Balance}\t{this.InterestRate}";
        }
    }
}
