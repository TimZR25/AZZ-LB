using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1
{
    internal class Bag
    {
        public Bag(List<FoodProduct> products, string name, double maxWeight)
        {
            _products = products;
            Name = name;
            MaxWeight = maxWeight;
        }

        public double TotalWeight { set { totalWeight = value; } get { return totalWeight; } }
        public void SetOfBag(FoodProduct foodProduct)
        {
            Name = name;
            MaxWeight = maxWeight;
        }

        private List<FoodProduct> _products = new List<FoodProduct>();

    }
}
