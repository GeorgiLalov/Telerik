namespace Dealership.Models.Abstract
{
    using System.Collections.Generic;

    using Contracts;
    using Common.Enums;
    using Common;

    public abstract class Vehicle : IVehicle
    {
        private string make;
        private string model;
        private decimal price;

        public Vehicle(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Comments = new List<IComment>();
        }

        public string Make
        {
            get
            {
                return this.make;
            }

            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinMakeLength, Constants.MaxMakeLength,
                                        string.Format(Constants.StringMustBeBetweenMinAndMax, "make", Constants.MinMakeLength, Constants.MaxMakeLength));
                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinModelLength, Constants.MaxModelLength,
                                        string.Format(Constants.StringMustBeBetweenMinAndMax, "model", Constants.MinModelLength, Constants.MaxModelLength));
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                Validator.ValidateDecimalRange(value, Constants.MinPrice, Constants.MaxPrice,
                                        string.Format(Constants.StringMustBeBetweenMinAndMax, "price", Constants.MinPrice, Constants.MaxPrice));
                this.price = value;
            }
        }
        
        public IList<IComment> Comments { get; private set; }

        public abstract VehicleType Type { get; }
        public abstract int Wheels { get; }
    }
}
