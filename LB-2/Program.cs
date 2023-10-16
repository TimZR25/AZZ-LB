using LB3_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_2
{
    internal class Program
    {
        public static void Main() {
            //Часть 1
            Console.WriteLine("---------------Часть №1----------------------");

            int N1 = 3;
            int N2 = 5;
            Matrix matrix = new Matrix(N1, N2);
            matrix[0, 1] = 1;

            //matrix.PrintMatrix();
            // Часть 2

            Console.WriteLine("\n---------------Часть №2----------------------");

            Car car = new Car("Cabriolet", 160, 2009, 1000000, 60);

            Train train = new Train("САПСАН", 90, 2003, 1000000, 80, new List<Carriage>() { new Carriage(1000), new Carriage(200) });

            Train train1 = new Train("САПСАН", 140, 2012, 1500000, 150, new List<Carriage>() {});

            ExpressTrain expressTrain = new ExpressTrain("САПСАН", 220, 2020, 40000000, 220, new List<Carriage>() { new Carriage(100) });

            Transport[] array = new Transport[] { car, train, train1, expressTrain};

            foreach (Transport obj in array)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(obj);
                obj.StartTransport();
                obj.StopTransport();
                Console.WriteLine("---------------------------------------");
            }


            Carriage carriage1 = new Carriage(200);

            Carriage carriage2 = new Carriage(200);

            Console.WriteLine(carriage2.Equals(carriage1));
            Console.WriteLine(carriage2.GetHashCode() == carriage1.GetHashCode());

        }
    }
}
