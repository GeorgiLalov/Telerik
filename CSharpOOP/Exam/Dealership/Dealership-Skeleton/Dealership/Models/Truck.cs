namespace Dealership.Models
{
    using System;

    using Abstract;
    using Contracts;
    using Common.Enums;
    using Common;
    public class Truck : Vehicle, ITruck
    {
        private int weightCapacity;

        public Truck(string make, string model, decimal price, int weightCapacity)
            : base(make, model, price)
        {
            this.WeightCapacity = weightCapacity;
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Truck;
            }
        }

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }

            private set
            {
                Validator.ValidateIntRange(value, Constants.MinCapacity, Constants.MaxCapacity,
                                        string.Format(Constants.StringMustBeBetweenMinAndMax, "capacity", Constants.MinCapacity, Constants.MaxCapacity));
                this.weightCapacity = value;
            }
        }

        public override int Wheels
        {
            get
            {
                return (int)VehicleType.Truck;
            }
        }
    }
}
