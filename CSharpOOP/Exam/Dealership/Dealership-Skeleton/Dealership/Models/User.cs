namespace Dealership.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;
    using Common.Enums;
    using Common;

    public class User : IUser
    {
        private string firstName;
        private string lastName;
        private string password;
        private string userName;

        public User(string username, string firstName, string lastName, string password, string role)
        {
            this.Username = userName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = this.GetRole(role);
            this.Vehicles = new List<IVehicle>();
            this.Comments = new Dictionary<IVehicle, IComment>();
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength
                                            , string.Format(Constants.StringMustBeBetweenMinAndMax, "firstName", Constants.MinNameLength, Constants.MaxNameLength));
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength
                                            , string.Format(Constants.StringMustBeBetweenMinAndMax, "lastName", Constants.MinNameLength, Constants.MaxNameLength));
                this.lastName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            private set
            {
                Validator.ValidateSymbols(value, Constants.PasswordPattern, string.Format(Constants.InvalidSymbols, "password"));

                Validator.ValidateIntRange(value.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength,
                                    string.Format(Constants.StringMustBeBetweenMinAndMax, "password", Constants.MinPasswordLength, Constants.MaxPasswordLength));

                this.password = value;
            }
        }

        public Role Role { get; private set; }

        public string Username
        {
            get
            {
                return this.userName;
            }

            private set
            {
                Validator.ValidateSymbols(value, Constants.UsernamePattern, string.Format(Constants.InvalidSymbols, "userName"));

                this.userName = value;
            }
        }

        public IList<IVehicle> Vehicles { get; private set; }

        public Dictionary<IVehicle, IComment> Comments { get; private set; }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            this.Comments.Add(vehicleToAddComment, commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            if (this.Role == Role.Admin)
            {
                throw new ArgumentException(Constants.AdminCannotAddVehicles);
            }
            else if (this.Role != Role.VIP && this.Vehicles.Count == Constants.MaxVehiclesToAdd)
            {
                throw new ArgumentException(string.Format(Constants.NotAnVipUserVehiclesAdd, Constants.MaxVehiclesToAdd));
            }
            else
            {
                this.Vehicles.Add(vehicle);
            }
        }

        public string PrintVehicles()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(string.Format("-USER {0}--", this.userName));

            for (int index = 0; index < this.Vehicles.Count; index++)
            {
                IVehicle vehicle = this.Vehicles[index];
                builder.AppendLine(string.Format("{0}. {1}:", index, vehicle.Type));
                builder.AppendLine(string.Format("  Make: {0}", vehicle.Make));
                builder.AppendLine(string.Format("  Model: {0}", vehicle.Model));
                builder.AppendLine(string.Format("  Wheels: {0}", vehicle.Wheels));
                builder.AppendLine(string.Format("  Price: ${0}", vehicle.Price));

                switch (vehicle.Type)
                {
                    case VehicleType.Motorcycle:
                        builder.AppendLine("  Category:");
                        break;
                    case VehicleType.Car:
                        builder.AppendLine("  Seats:");
                        break;
                    case VehicleType.Truck:
                        builder.AppendLine("  Weight capacity:");
                        break;
                    default:
                        break;
                }

                if (this.Comments.Count == 0)
                {
                    builder.AppendLine("    --NO COMMENTS--");
                }
                else
                {
                    builder.AppendLine("    --COMMENTS--");
                    foreach (var comment in this.Comments)
                    {
                        builder.AppendLine("    ----------");
                        builder.AppendLine(string.Format("    {0}", comment.Value.Content));
                        builder.AppendLine(string.Format("        User: {0}", comment.Value.Author));
                        builder.AppendLine("    ----------");
                    }
                    builder.AppendLine("    --COMMENTS--");
                }
            }

            return builder.ToString();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            this.Comments.Remove(vehicleToRemoveComment);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            this.Vehicles.Remove(vehicle);
        }

        private Role GetRole(string input)
        {
            Role role = Role.Normal;

            switch (input.ToLower())
            {
                case "vip":
                    role = Role.VIP;
                    break;
                case "admin":
                    role = Role.Admin;
                    break;
            }

            return role;
        }
    }
}
