﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LB3_2
{
    internal class Car : Transport
    {
        public Engine CarEngine { get; private set; }

        public Car(string model, double maxSpeed, int creationYear, double price, int power)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            CreationYear = creationYear;
            Price = price;
            CarEngine = new Engine(power);
        }

        public override void StartTransport()
        {
            CarEngine.TurnOn();
            Console.WriteLine("Автомобиль отправился в путь");
        }

        public override void StopTransport()
        {
            CarEngine.TurnOff();
            Console.WriteLine("Автомобиль остановился");
        }

        public override string ToString()
        {
            return new string($"Данные машины:\nМодель: {Model}, Максимальная скорость: {MaxSpeed}, " +
                $"Год создания: {CreationYear}\nСтоимость: {Price}, {CarEngine}");
        }
    }
}
