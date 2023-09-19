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

        private float _weight;

        public float Weight { get { return _weight; } set { _weight = value; } }

        private float _temperature;
        public float Temperature { get { return _temperature; } set { _temperature = value; } }

        private float _maxTemperature;
        public float MaxTemperature { get { return _maxTemperature; } set { _maxTemperature = value; } }

        private float _minTemperature;
        public float MinTemperature { get { return _minTemperature; } set { _minTemperature = value; } }

        private string _status = "Нормально";
        public string Status { get { return _status; } set { _status = value; } }

        private float _heatCapacity;
        public float HeatCapacity { get { return _heatCapacity; } set { _heatCapacity = value; } }

        private float _thermalEnergy;
        public float ThermalEnergy { get { return _thermalEnergy; } set { _thermalEnergy = value; } }


        public void ChangeStatus()
        {
            if (_temperature >= _maxTemperature) { _status = "Перегрет"; }
            else { _status = "Переморожен"; }
        }


    }
}
