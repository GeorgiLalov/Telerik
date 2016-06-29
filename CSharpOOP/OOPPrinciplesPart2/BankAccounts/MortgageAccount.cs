namespace BankAccounts
{
    using System;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer) : base(customer)
        {
        }

        public override void CalcInterestRate(int numberOfMonths)
        {
            if (this.Customer.Type == CustomerType.Individual && numberOfMonths <= 6)
            {
                Console.WriteLine("Mortgage Accounts for Individuals have no Interest Rate for 6 months");
            }
            else if(this.Customer.Type == CustomerType.Company && numberOfMonths <= 12)
            {
                base.CalcInterestRate(numberOfMonths);
                this.InterestRate /= 2;
            }
            else
            {
                base.CalcInterestRate(numberOfMonths);
            }
        }
    }
}
