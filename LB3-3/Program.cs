using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_3
{
    class Program
    {
        public static void Main() {
            int sizeField = 3; // размер поля
            Field field = Field.getInstance(sizeField);
            field.FieldOut();

            Console.WriteLine("===============================\n\n");

            field.AddModel(new God_Emperor(), 1, 0);
            field.AddModel(new Rock(), 1, 1);
            field.FieldOut();
        }
    }
}
