namespace BankAccounts
{
    using System;

    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer) : base(customer)
        {
        }

        public override void CalcInterestRate(int numberOfMonths)
        {
            if (this.Customer.Type == CustomerType.Individual && numberOfMonths <= 3)
            {
                Console.WriteLine("Loan Accounts for Individuals have no Interest Rate for 3 months");
            }
            else if (this.Customer.Type == CustomerType.Company && numberOfMonths <= 2)
            {
                Console.WriteLine("Loan Accounts for Companies have no Interest Rate for 2 months");
            }
            else
            {
                base.CalcInterestRate(numberOfMonths);
            }
        }
    }
}
