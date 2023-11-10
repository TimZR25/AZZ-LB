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

            const int N1 = 4;
            const int N2 = 4;

            Matrix matrix = new Matrix(new int[N1, N2] { 
            { 1, 2, 3, 4}, 
            { 1, 2, 3, 4}, 
            { 1, 2, 3, 4}, 
            { 1, 2, 3, 4}
            });

            matrix[0, 2] = 1;

            matrix.PrintMatrix();

            matrix--;

            matrix.PrintMatrix();

            matrix++;

            matrix.PrintMatrix();

            int count = matrix;

            Console.WriteLine("Количество нулевых элементов: " + count + "\n");

            Console.WriteLine("Проверка на квадратность матрицы: " + matrix.SquareMatrix() + "\n");

            Console.WriteLine("Модуль матрицы: " + matrix.ModMatrix());

            Matrix matrix1 = new Matrix(new int[N1, N2] {
            { 1, 2, 3, 4},
            { 1, 2, -3, 4},
            { 1, 2, 3, 4},
            { 1, 2, 3, 4}
            });

            Console.WriteLine("\nМатрицы равны: " + (matrix == matrix1));

            matrix1[0, 0] = -1;

            Console.WriteLine("\nМатрицы не равны: " + (matrix1 != matrix));


            // Пример расширения класса String

            string a = "555ad551b01";
            Console.WriteLine("\nСумма целых чисел в строке: " + a.SumNumber());

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
