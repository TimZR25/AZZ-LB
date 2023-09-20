using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LB_1
{
    class FoodProduct
    {
        public FoodProduct(string name = "NULL", double weight = 0, double temperature = 0, double maxTemperature = 0,
            double minTemperature = 0, double heatCapacity = 0)
        {
            Name = name;
            Weight = weight;
            Temperature = temperature;
            HeatCapacity = heatCapacity;
            MaxTemperature = maxTemperature;
            MinTemperature = minTemperature;
        }

        public FoodProduct(FoodProduct foodProduct)
        {
            Name = foodProduct.Name;
            Weight = foodProduct.Weight;
            Temperature = foodProduct.Temperature;
            HeatCapacity = foodProduct.HeatCapacity;
            MaxTemperature = foodProduct.MaxTemperature;
            MinTemperature = foodProduct.MinTemperature;
        }

        private string _name = "NULL";
        public string Name
        {
            get { return _name; }
            private set 
            { 
                if (value == string.Empty) throw new ArgumentNullException("Неправильно указано имя продукта");
                _name = value; 
            }
        }
        
        private double _weight;
        public double Weight 
        { 
            get { return _weight; }
            private set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Неправильно указана масса продукта");
                _weight = value; 
            } 
        }

        public float Weight { get { return _weight; } set { _weight = value; } }

        private float _temperature;
        public float Temperature { get { return _temperature; } set { _temperature = value; } }

        private float _maxTemperature;
        public float MaxTemperature { get { return _maxTemperature; } set { _maxTemperature = value; } }

        private float _minTemperature;
        public float MinTemperature { get { return _minTemperature; } set { _minTemperature = value; } }

        private double _heatCapacity;
        public double HeatCapacity 
        { 
            get { return _heatCapacity; } 
            private set 
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Неправильно указана теплоемкость продукта");
                _heatCapacity = value; 
            } 
        }

        private float _heatCapacity;
        public float HeatCapacity { get { return _heatCapacity; } set { _heatCapacity = value; } }

        private float _thermalEnergy;
        public float ThermalEnergy { get { return _thermalEnergy; } set { _thermalEnergy = value; } }


        private void ChangeStatus()
        {
            if (_temperature >= _maxTemperature) { _status = "Перегрет"; }
            else { _status = "Переморожен"; }
        }
    }
}