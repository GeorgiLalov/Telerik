namespace Dealership.Models
{
    using Abstract;
    using Contracts;
    using Common.Enums;
    using Common;

    public class Car : Vehicle, ICar
    {
        private int seats;

        public Car(string make, string model, decimal price, int seats)
            : base(make, model, price)
        {
            this.Seats = seats;
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }

            private set
            {
                Validator.ValidateIntRange(value, Constants.MinSeats, Constants.MaxSeats,
                                        string.Format(Constants.StringMustBeBetweenMinAndMax, "seats", Constants.MinSeats, Constants.MaxSeats));
                this.seats = value;
            }
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Car;
            }
        }

        public override int Wheels
        {
            get
            {
                return (int)VehicleType.Car;
            }
        }
    }
}
