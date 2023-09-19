using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1
{
    internal class Bag
    {
        private List<FoodProduct> _products = new List<FoodProduct>();

        public void AddProduct(FoodProduct foodProduct)
        {
            _products.Add(foodProduct);
        }

        public FoodProduct GetProduct(string productName)
        {
            foreach (FoodProduct product in _products)
            {
                if (productName != product.Name) continue;
                
                return product;
            }

            return null;
        }
    }
}
