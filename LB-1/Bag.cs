using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1
{
    class Bag
    {
        private List<FoodProduct> bag = new List<FoodProduct>();
        private double maxWeight = 14; // вес в килограммах
        private double totalWeight = 0;
        public double MaxWeight { get { return maxWeight; } }

        public double TotalWeight { set { totalWeight = value; } get { return totalWeight; } }
        public void SetOfBag(FoodProduct foodProduct)
        {

            totalWeight += foodProduct.Weight;
            if (totalWeight > maxWeight) throw new ArgumentOutOfRangeException("Превышен предел сумки");
            bag.Add(foodProduct);
        }

        public FoodProduct PeekUpTheProduct()
        {
            TotalWeight -= bag[-1].Weight;
            FoodProduct foodProduct = bag.Last();
            bag.Remove(foodProduct);
            return foodProduct;
        }

        public int ProductCount() {
            return bag.Count();
        }

        public void ChangeTheTemperatureInTheBag() {
            double totalTemperature = 0;
            for (int i = 0; i < bag.Count(); i++ ){
                if (i == 0)
                {
                    totalTemperature = bag[i].Temperature;
                    continue;
                }
                totalTemperature += bag[i].Temperature;
            }
            totalTemperature /= bag.Count();
            for (int i = 0; i < bag.Count(); i++) {
                bag[i].Temperature = totalTemperature;
            }
        }

        public int CountSpoiledProducts() {
            int countSpoiledProducts = 0;
            foreach (FoodProduct foodProduct in bag) {
                foodProduct.ChangeStatus();
                if (!foodProduct.Status.Equals("Нормально")) {
                    countSpoiledProducts++;
                }
            }
            return countSpoiledProducts;
        }
    }
}
