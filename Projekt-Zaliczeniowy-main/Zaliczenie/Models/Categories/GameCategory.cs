﻿using Zaliczenie.Interfaces;

namespace Zaliczenie.Models.Categories
{
    public class GameCategory : ICategory
    {
        public List<Product> Products { get; set; }

        public void DisplayProducts()
        {
            int counter = 1;
            foreach (var product in Products)
            {
                product.DisplayProduct(counter);
                counter++;
            }
        }

        public bool RemoveProductAtIndex(Index index)
        {
            try
            {
                Products.RemoveAt(index.Value);
            }
            catch (Exception x)
            {
                return false;
            }
            return true;
        }

        public IProduct GetProductFromAtIndex(Index index)
        {
            Product product;
            try
            {
                product = Products.ElementAt(index);
            }
            catch (Exception x)
            {
                return null;
            }
            return product;
        }
    }
}