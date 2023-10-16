using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_2
{
    internal class Engine
    {
        private int Power { set; get; }

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

        public override String ToString() {
            return $"Мощность двигателя: {Power}, Состояние двигателя: {Status}";
        }
    }
}
