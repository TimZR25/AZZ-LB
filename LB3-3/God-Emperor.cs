using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_3
{
    internal class God_Emperor : Unit
    {

        public God_Emperor()
        {
            Health = int.MaxValue;
            Armor = int.MaxValue;
            distance = int.MaxValue;
        }

        public override void Death()
        {
            Console.WriteLine("Бог не может умереть");
            Health = int.MaxValue;
            Armor = int.MaxValue;
        }

        public override string GetSign()
        {
            return "G";
        }

        public override void Move()
        {
            
        }
    }
}
