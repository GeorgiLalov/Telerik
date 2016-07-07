namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Contracts;
    using Common;

    public class Category : ICategory
    {
        private string name;

        public ICollection<IProduct> Products { get; private set; }

        private readonly int minNameLength = 2;
        private readonly int maxNameLength = 15;

        public Category( string name)
        {
            this.Name = name;
            this.Products = new List<IProduct>();
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
                    , string.Format(GlobalErrorMessages.InvalidStringLength, this.GetType().Name, this.minNameLength, this.maxNameLength));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.Products.Add(cosmetics);

            this.Products = SortProducts(this.Products);
        }

        public string Print()
        {
            StringBuilder print = new StringBuilder();

            print.AppendLine($"{this.name} category – {this.Products.Count} products/product in total");
            foreach (IProduct product in this.Products)
            {
                print.AppendLine(product.Print());
            }

            return print.ToString();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!this.Products.Remove(cosmetics))
            {
                Console.WriteLine("Product {0} does not exist in category {0}!", cosmetics.Name, this.Name);
            }
        }

        // sort by brand in ascending order and then by price in descending order
        private ICollection<IProduct> SortProducts(ICollection<IProduct> products)
        {
            return products
                            .OrderBy(product => product.Brand)
                            .ThenByDescending(product => product.Price)
                            .ToList();
        }
    }
}
