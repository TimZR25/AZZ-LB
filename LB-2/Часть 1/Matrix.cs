﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_2
{
    internal class Matrix
    {
        private int[,] _matrix;

        public int[,] GetMatrix() {
            return _matrix;
        }

        public Matrix(int[,] newMatrix) {
            _matrix = newMatrix;
        }

        public int this[int i, int j]
        {
            get => _matrix[i, j];
            set => _matrix[i, j] = value;
        }

        public void PrintMatrix() {

            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    Console.Write(_matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static Matrix operator --(Matrix matrix)
        {
            for (int i = 0; i < matrix._matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix._matrix.GetLength(1); j++)
                {
                    matrix._matrix[i, j]--;
                }
            }
            return matrix;
        }

        public static Matrix operator ++(Matrix matrix)
        {
            for (int i = 0; i < matrix._matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix._matrix.GetLength(1); j++)
                {
                    matrix._matrix[i, j]++;
                }
            }
            return matrix;
        }


        public static implicit operator int(Matrix matrix) 
        {
            int count = 0;

            for (int i = 0; i < matrix._matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix._matrix.GetLength(1); j++)
                {
                    if (matrix._matrix[i, j] == 0) count++;
                }
            }

            return count;
        }

        public int ModMatrix()
        {
            int count = 0;

            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    count += Math.Abs(_matrix[i, j]);
                }
            }

            return count;
        }

        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            return matrix1.ModMatrix() != matrix2.ModMatrix();
        }
        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            return matrix1.ModMatrix() == matrix2.ModMatrix();
        }

    }
}
