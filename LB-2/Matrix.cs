using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_3
{
    internal class Matrix// надо доработать класс
    {
        int[,] matrix;

        public Matrix(int i, int j) {
            matrix = new int[i, j];
        }

        public int this[int i, int j]
        {
            get => matrix[i, j];
            set => matrix[i, j] = value;
        }

        public void PrintMatrix() {
            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(Math.Abs(matrix.Length - matrix.GetLength(1)));

            for (int i = 0; i < Math.Abs(matrix.Length - 1 - matrix.GetLength(1)); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            //int count = 0;

            //foreach (int i in matrix) {
            //    if (count == matrix.GetLength(0))
            //    {
            //        Console.WriteLine();
            //        count = 0;
            //    }
            //    count++;
            //    Console.Write(i); 
            //}
        }
    }
}
