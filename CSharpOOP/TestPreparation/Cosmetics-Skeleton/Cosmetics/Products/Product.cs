namespace Cosmetics.Products
{
    using Contracts;
    using Common;

    public abstract class Product : IProduct
    {
        private readonly int minNameLength = 3;
        private readonly int maxNameLength = 10;
        private readonly int minBrandLength = 3;
        private readonly int maxBrandLength = 10;

        private string name;
        private string brand;
        private GenderType gender;
        private decimal price;

        public Product(string brand, GenderType gender, string name, decimal price)
        {
            this.Brand = brand;
            this.Gender = gender;
            this.Name = name;
            this.Price = price;
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                Validator.CheckIfStringLengthIsValid(value, this.maxBrandLength, this.minBrandLength
                                    , string.Format(GlobalErrorMessages.InvalidStringLength, "brand", this.minBrandLength, this.maxBrandLength));

                this.brand = value;
            }
        }
        public GenderType Gender
        {
            get
            {
                return this.gender;
            }

            private set
            {
                Validator.CheckIfNull(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "gender"));

                this.gender = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfStringLengthIsValid(value, this.maxNameLength, this.minNameLength
                    , string.Format(GlobalErrorMessages.InvalidStringLength, "name", this.minNameLength, this.maxNameLength));

                this.name = value;
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
                Validator.CheckIfNull(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "price"));

                this.price = value;
            }
        }

        public abstract string Print();
    }
}
