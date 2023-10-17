using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LB3_2
{
    static class MatrixExtension
    {
        public static bool SquareMatrix(this Matrix matrix) {
            return matrix.GetMatrix().GetLength(0) == matrix.GetMatrix().GetLength(1);
        }
    }
}
