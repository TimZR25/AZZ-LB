using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LB3_2
{
    internal class Train : Transport
    {
        public Engine TrainEngine { get; private set; }

        private double CarriageCapacity { get; set; }

        private List<Carriage> Carriages { get; set; }

        public Train(string model, double maxSpeed, int creationYear, double price, int power, List<Carriage> carriages)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            CreationYear = creationYear;
            Price = price;
            TrainEngine = new Engine(power);
            Carriages = carriages;
            CountCarriageCapacity();
        }

        public void AddCarriage(Carriage carriage)
        {
            Carriages.Add(carriage);
            CountCarriageCapacity();
        }

        private void CountCarriageCapacity()
        {
            CarriageCapacity = 0;
            foreach (Carriage c in Carriages) CarriageCapacity += c.Capacity;
        }

        public override void StartTransport()
        {
            TrainEngine.TurnOn();
            Console.WriteLine("Поезд отправился в путь");
        }

        public override void StopTransport()
        {
            TrainEngine.TurnOff();
            Console.WriteLine("Поезд остановился");
        }

        public override string ToString()
        {
            string s = "\nВместимость вагонов поезда:";
            if (Carriages.Count == 0) { s = ""; }

            for (int i = 0; i < Carriages.Count; i++)
            {
                s = s + "\nВагон " + i + " " + Carriages[i].ToString();
            }
            return new string($"Данные поезда:\nМодель: {Model}, Максимальная скорость: {MaxSpeed}, " +
                $"Год создания: {CreationYear}\nСтоимость: {Price}, {TrainEngine}, Общая вместимость вагонов: {CarriageCapacity}" + s);
        }
    }
}
