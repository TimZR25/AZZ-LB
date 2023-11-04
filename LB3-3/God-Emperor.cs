using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_3
{
    internal class God_Emperor : Unit
    {

        public God_Emperor(int x, int y, Field field) {
            for (int i = 0; i < field.size * field.size; i++) {
                if (field) { }
            }//hjuiohuioj
            Health = 9999;
            Armor = 9999;
        }
        public override void Death()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            
        }
    }
}
