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
            Bag bag = new Bag("Сумка №1", 5);

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
                bag.AddProduct(new FoodProduct("Мороженое", 0.1, -2.3, 0, -6, 0.35));
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine(error.Message);
            }

            try
            {
                bag.AddProduct(new FoodProduct("Яблоко", 0.1, 22.25, 25, -5, 0.53));
            }
            catch (ArgumentNullException error)
            {
                Console.WriteLine(error.Message);
            }

            bag.Print();

            Console.WriteLine($"Количество испорченных продуктов: {bag.GetSpoiledProductsCount()}");

            List<FoodProduct> products = new List<FoodProduct>();
            products.Add(new FoodProduct("Кофе", 0.3, 80, 25, -5, 0.53));
            Console.WriteLine($"Количество возможно испорченных продуктов при добавление новых продуктов: {bag.GetPossibleSpoiledProductsCount(products)}");
        }
    }