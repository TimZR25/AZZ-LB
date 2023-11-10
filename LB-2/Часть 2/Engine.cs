using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_2
{
    internal class Engine
    {
        public int Power { get; private set; }

        enum StatusEngine {
            OFF,
            ON
        }

        public Engine(int power)
        {
            Power = power;
        } 

        private StatusEngine Status = StatusEngine.OFF;

        public void TurnOn() {
            Status = StatusEngine.ON;
        }

        public void TurnOff() {
            Status = StatusEngine.OFF;
        }

        public override string ToString() {
            return $"Мощность двигателя: {Power}, Состояние двигателя: {Status}";
        }
    }
}
