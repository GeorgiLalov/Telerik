namespace Dealership.Models
{
    using Abstract;
    using Contracts;
    using Common.Enums;
    using Common;

    public class Motorcycle : Vehicle, IMotorcycle
    {
        private string category;

        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price)
        {
            this.Category = category;
        }

        public string Category
        {
            get
            {
                return this.category;
            }

            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength,
                                        string.Format(Constants.StringMustBeBetweenMinAndMax, "category", Constants.MinCategoryLength, Constants.MaxCategoryLength));
                this.category = value;
            }
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Motorcycle;
            }
        }

        public override int Wheels
        {
            get
            {
                return (int)VehicleType.Motorcycle;
            }
        }
    }
}
