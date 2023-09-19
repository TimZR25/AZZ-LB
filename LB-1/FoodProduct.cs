using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1
{
    class FoodProduct
    {

        private string _name;
        public string Name { set { _name = value; } get { return _name; } }

        private double _weight;

        public double Weight { get { return _weight; } set { _weight = value; } }

        private double _temperature;
        public double Temperature { get { return _temperature; } set { _temperature = value; } }

        private double _maxTemperature;
        public double MaxTemperature { get { return _maxTemperature; } set { _maxTemperature = value; } }

        private double _minTemperature;
        public double MinTemperature { get { return _minTemperature; } set { _minTemperature = value; } }

        private string _status = "Нормально";
        public string Status { get { return _status; } set { _status = value; } }

        private double _heatCapacity;
        public double HeatCapacity { get { return _heatCapacity; } set { _heatCapacity = value; } }

        public FoodProduct(string name = "", double weight = 0, double temperature = 0, double maxTemperature = 0, double minTemperature = 0, double heatCapacity = 0)
        {
            if (name == "") throw new ArgumentNullException("Неправильно указано имя продукта");
            if (weight <= 0) throw new ArgumentOutOfRangeException("Неправильно указана масса продукта");
            if ((temperature <= -50) || (temperature > 70)) throw new ArgumentOutOfRangeException("Неправильно указана температура продукта");
            if (heatCapacity == 0) throw new ArgumentOutOfRangeException("Неправильно указана теплоемкость продукта");
            _name = name;
            _weight = weight;
            _temperature = temperature;
            _maxTemperature = maxTemperature;
            _minTemperature = minTemperature;
            _heatCapacity = heatCapacity;
            ChangeStatus();
        }
        public void ChangeStatus()
        {
            if (_temperature >= _maxTemperature) { _status = "Перегрет"; }
            else { _status = "Переморожен"; }
        }


    }
}