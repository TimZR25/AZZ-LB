using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_3
{
    abstract class Unit
    {
        public int Health { get; protected set; }
        public int Armor { get; protected set; }

        private Cell cell;
        abstract public void Move();

        abstract public void Death();

        public List<IAbilitiy> abilitiys;
    }
}
