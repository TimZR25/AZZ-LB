using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1
{
    internal class FoodProduct
    {

        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        private float weight;

        public float Weight { get { return weight; } set { weight = value; } }

        private float temperature;
        public float Temperature { get { return temperature; } set { temperature = value; } }

        private float maxTemperature;
        public float MaxTemperature { get { return maxTemperature; } set { maxTemperature = value; } }

        private float minTemperature;
        public float MinTemperature { get { return minTemperature; } set { minTemperature = value; } }

        private String status = "Нормально";
        public String Status { get { return status; } set { status = value; } }

        private float heatCapacity;
        public float HeatCapacity { get { return heatCapacity; } set { heatCapacity = value; } }

        private float thermalEnergy;
        public float ThermalEnergy { get { return thermalEnergy; } set { thermalEnergy = value; } }


        public void ChangeStatus()
        {
            if (temperature >= maxTemperature) { status = "Перегрет"; }
            else { status = "Переморожен"; }
        }


    }
}
