using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_2
{
    internal abstract class Transport
    {
        protected double MaxSpeed { get; set; }

        protected String Model { get; set; }

        protected int CreationYear { get; set; }

        protected double Price { get; set; }

        public abstract void StartTransport();

        public abstract void StopTransport();
    }
}
