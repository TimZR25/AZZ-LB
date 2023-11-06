using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_3
{
    internal class Cell
    {
        public int x { get; }

        public int y { get; }

        private bool isEmpty = true;

        ICellable model;

        string sign = "0";
        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //public override string ToString()
        //{
        //    return $"{x}:{y} ";
        //}

        public void AddModelInCell(ICellable model) {
            this.model = model;
            sign = model.GetSign();
        }

        public override string ToString()
        {
            return sign + " ";
        }

        public bool GetIsEmpty() {
            return isEmpty;
        }
    }
}
