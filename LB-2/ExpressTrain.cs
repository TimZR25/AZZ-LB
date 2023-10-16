using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_2
{
    internal class ExpressTrain : Train, Express
    {
        public ExpressTrain(string model, double maxSpeed, int creationYear, double price, int power, List<Carriage> carriages) : base(model, maxSpeed, creationYear, price, power, carriages)
        {
        }

        public String COut()
        {
            return "Экспресс поезд";
        }

        public override String ToString()
        {
            return base.ToString() + "\n" + COut();
        }
    }
}
