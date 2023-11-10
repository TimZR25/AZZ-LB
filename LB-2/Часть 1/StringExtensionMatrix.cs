using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_2
{
    static class StringExtensionMatrix
    {
        public static int SumNumber(this string str)
        {
            StringBuilder sb = new StringBuilder();

            int summ = 0;
            int number;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 48 || str[i] > 57)
                {
                    int.TryParse(sb.ToString(), out number);
                    summ += number;
                    sb.Clear();

                    continue;
                }

                sb.Append(str[i]);
            }
            int.TryParse(sb.ToString(), out number);
            summ += number;


            return summ;
        }
    }
}
