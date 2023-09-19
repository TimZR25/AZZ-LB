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

            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine(error.Message);
            }

            try
            {
                FoodProduct foodProduct2 = new FoodProduct("Food", 1350, 139.6, 30, 20, 20);
                Console.WriteLine(foodProduct2.Name);
            }
            catch (ArgumentNullException error)
            {
                Console.WriteLine(error.Message);
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine(error.Message);
            }

            try
            {
                FoodProduct foodProduct3 = new FoodProduct("Food", 1350, 39.6, 40, 20, 10);
                Console.WriteLine(foodProduct3.Name);
                Console.WriteLine(foodProduct3.Weight);
                Console.WriteLine(foodProduct3.Temperature);
                Console.WriteLine(foodProduct3.MaxTemperature);
                Console.WriteLine(foodProduct3.MinTemperature);
                Console.WriteLine(foodProduct3.HeatCapacity);
                Console.WriteLine(foodProduct3.Status);
                Console.WriteLine(foodProduct3.C);
                cout << f1.GetChangeTemperature() << endl;
                cout << f1.GetChangeTemperature() << endl;
            }
            catch (ArgumentNullException error)
            {
                Console.WriteLine(error.Message);
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine(error.Message);
            }




            //return 0;
            //}

        }
        }
    }