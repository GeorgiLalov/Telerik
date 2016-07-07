namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Contracts;
    using Common;
    
    public class Shampoo : Product, IShampoo, IProduct
    {
        private uint milliliters;
        private UsageType usage;

        public Shampoo(string brand, GenderType gender, string name, decimal price, uint milliliters, UsageType usage)
            : base(brand, gender, name, price)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters
        {
            get
            {
                return this.milliliters;
            }

            private set
            {
                Validator.CheckIfNull(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "milliliters"));

                this.milliliters = value;
            }
        }

        public UsageType Usage
        {
            get
            {
                return this.usage;
            }

            private set
            {
                Validator.CheckIfNull(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "usage"));

                this.usage = value;
            }
        }

        public override string Print()
        {
            StringBuilder print = new StringBuilder();

            print.AppendLine($"- {this.Brand} – {this.Name}:");
            print.AppendLine($"* Price: ${this.Price}");
            print.AppendLine($"* For gender: {this.Gender}");
            print.AppendLine($"* Quantity: {this.Milliliters} ml (when applicable)");
            print.AppendLine($"* Usage: {this.Usage} (when applicable)");

            return print.ToString();
        }
    }
}
