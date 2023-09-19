using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1
{
    class MainClass
    {
        static void Main()
        {
            Bag bag = new Bag("Сумка адын", 5);

            try
            {
                bag.AddProduct(new FoodProduct("Сыр", 6, 15.3, 25, -5, 0.53));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

            try
            {
                bag.AddProduct(new FoodProduct("Мороженое", 0.5, -2.3, 23, -6, 0.35));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

            try
            {
                bag.AddProduct(new FoodProduct("Яблоко", 0.3, 22.25, 25, -5, 0.53));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
            
            List<FoodProduct> products = new List<FoodProduct>();
            products.Add(new FoodProduct("Яблоко", 0.3, 100, 25, -5, 0.53));
            Console.WriteLine(bag.GetPossibleSpoiledProductsCount(products));
            bag.Print();
        }
        }
    }