using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1
{
    internal class Bag
    {
        public Bag(List<FoodProduct> products, string name, double maxWeight)
        {
            _products = products;
            Name = name;
            MaxWeight = maxWeight;
        }

        public Bag(string name, double maxWeight)
        {
            Name = name;
            MaxWeight = maxWeight;
        }

        private List<FoodProduct> _products = new List<FoodProduct>();

        public int ProductsCount => _products.Count;

        private string _name;
        public string Name
        {
            get { return _name; }
            private set
            {
                if (value == string.Empty) throw new ArgumentNullException("Неправильно указано имя сумки");
                _name = value;
            }
        }

        private double _weight;
        public double Weight
        {
            get { return _weight; }
            private set {  _weight = value; }
        }

        private double _maxWeight;
        public double MaxWeight
        {
            get { return _maxWeight; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Отрицательное значение максимального веса сумки");
                _maxWeight = value;
            }
        }

        public void AddProduct(FoodProduct newProduct)
        {
            if (Weight + newProduct.Weight > _maxWeight)
            {
                throw new ArgumentOutOfRangeException($"Невозможно добавить ---{newProduct.Name}--- c весом {newProduct.Weight} кг в сумку! Превышен лимит максимального веса сумки в {_maxWeight} кг!\n");
            }

            Weight += newProduct.Weight;

            _products.Add(newProduct);
            ChangeTemperature();
        }

        public FoodProduct GetProduct(string searchedProductName)
        {
            foreach (FoodProduct product in _products)
            {
                if (searchedProductName != product.Name) continue;

                Weight -= product.Weight;
                _products.Remove(product);
                return product;
            }
            Console.WriteLine("Продукта с таким именем не существует!");
            return null;
        }

        private void ChangeTemperature()
        {
            if (ProductsCount == 0)
            {
                Console.WriteLine("--------Сумка пуста!--------");
                return;
            }

            double totalTemperature = 0;

            foreach (FoodProduct product in _products)
            {
                totalTemperature += product.Temperature;
            }

            totalTemperature /= ProductsCount;

            foreach (FoodProduct product in _products)
            {
                product.Temperature = totalTemperature;
            }
        }

        public int GetSpoiledProductsCount()
        {
            if (ProductsCount == 0)
            {
                Console.WriteLine("--------Сумка пуста!--------");
                return 0;
            }

            int count = 0;
            foreach (FoodProduct product in _products)
            {
                if (product.Status == ProductStatus.NORMAL) continue;

                count++;
            }

            return count;
        }

        public int GetPossibleSpoiledProductsCount(List<FoodProduct> foodProducts)
        {
            if (foodProducts.Count == 0)
            {
                Console.WriteLine("--------Пустой список заданных продуктов!--------");
                return 0;
            }

            Bag tempBag = new Bag(Name, MaxWeight);
            foreach (FoodProduct product in _products)
            {
                tempBag.AddProduct(new FoodProduct(product));
            }

            foreach (FoodProduct product in foodProducts)
            {
                tempBag.AddProduct(new FoodProduct(product));
            }

            int count = tempBag.GetSpoiledProductsCount();

            return count;
        }

        public void Print()
        {
            if (ProductsCount == 0)
            {
                Console.WriteLine("--------Сумка пуста!--------");
                return;
            }

            int maxSymbolLenght = 35;
            int symbolsPerSide = (maxSymbolLenght - Name.Length) % 2 == 0 ? (maxSymbolLenght - Name.Length) / 2 : (maxSymbolLenght - Name.Length) / 2 + 1;
            Console.WriteLine(new string('=', symbolsPerSide) + Name + new string('=', symbolsPerSide));

            foreach (FoodProduct product in _products)
            {
                product.Print();
            }

            Console.WriteLine(new string('=', symbolsPerSide * 2 + Name.Length) + "\n");
        }
    }
}
