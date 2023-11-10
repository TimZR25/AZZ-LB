using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_2
{
    internal sealed class Carriage
    {
        public double Capacity { get; private set; }
        public Carriage(double capacity)
        {
            Capacity = capacity;
        }

        public override int GetHashCode()
        {
            return 37 * Capacity.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Carriage carriage) return Capacity == carriage.Capacity;
            return false;
        }
        public override string ToString()
        {
            return $"Вместимость вагона: {Capacity}";
        }
    }
}
