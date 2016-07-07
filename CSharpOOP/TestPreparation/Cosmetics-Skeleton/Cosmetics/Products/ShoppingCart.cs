namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    
    public class ShoppingCart : IShoppingCart
    {
        public ICollection<IProduct> Products { get; private set; }

        public ShoppingCart()
        {
            this.Products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            this.Products.Add(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.Products.Contains(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.Products.Remove(product);
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;

            foreach (IProduct product in this.Products)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }
    }
}
