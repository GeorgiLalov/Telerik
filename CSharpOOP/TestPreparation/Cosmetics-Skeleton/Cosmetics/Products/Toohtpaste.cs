namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Text;

    using Common;
    using Contracts;
    using System.Linq;
    public class Toohtpaste : Product, IToothpaste, IProduct
    {
        private readonly int minIngredientLength = 4;
        private readonly int maxIngredientLength = 12;
        private readonly string ingredientsSeparator = ", ";

        private string ingredients;

        public Toohtpaste(string brand, GenderType gender, string name, decimal price, ICollection<string> ingredients)
            : base(brand, gender, name, price)
        {
            this.Ingredients = this.ConvertIngredients(ingredients);
        }

        private string ConvertIngredients(ICollection<string> ingredients)
        {
            foreach (string ingredient in ingredients)
            {
                Validator.CheckIfStringLengthIsValid(ingredient, this.maxIngredientLength, this.minIngredientLength
                                , string.Format(GlobalErrorMessages.InvalidStringLength, "ingredient", this.minIngredientLength, this.maxIngredientLength));
            }

            return string.Join(this.ingredientsSeparator, ingredients);   
        }

        public string Ingredients
        {
            get
            {
                return this.ingredients;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "ingredients"));

                this.ingredients = value;
            }
        }

        public override string Print()
        {
            StringBuilder print = new StringBuilder();

            print.AppendLine($"- {this.Brand} – {this.Name}:");
            print.AppendLine($"* Price: ${this.Price}");
            print.AppendLine($"* For gender: {this.Gender}");
            print.AppendLine($" * Ingredients: {this.Ingredients} (when applicable)");

            return print.ToString();
        }
    }
}
