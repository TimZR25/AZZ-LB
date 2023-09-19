using System;
using System.Collections.Generic;
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

        public double TotalWeight { set { totalWeight = value; } get { return totalWeight; } }
        public void SetOfBag(FoodProduct foodProduct)
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
            TotalWeight -= bag[-1].Weight;
            FoodProduct foodProduct = bag.Last();
            bag.Remove(foodProduct);
            return foodProduct;
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
                throw new ArgumentOutOfRangeException($"Невозможно добавить ---{newProduct.Name}--- c весом {newProduct.Weight} в сумку! Превышен лимит максимального веса {_maxWeight}!\n");
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

        public void ChangeTheTemperatureInTheBag() {
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
                tempBag.AddProduct(product);
            }

            foreach (FoodProduct product in foodProducts)
            {
                tempBag.AddProduct(product);
            }

            int count = tempBag.GetSpoiledProductsCount();

            return count;
        }

        public int CountSpoiledProducts() {
            int countSpoiledProducts = 0;
            foreach (FoodProduct foodProduct in bag) {
                foodProduct.ChangeStatus();
                if (!foodProduct.Status.Equals("Нормально")) {
                    countSpoiledProducts++;
                }
            }

            Console.WriteLine(new string('=', symbolsPerSide * 2 + Name.Length) + "\n");
        }

        public int WillCountSpoiledProducts(List<FoodProduct> foodProducts) {
            foreach (FoodProduct foodProduct in foodProducts) {
                this.SetOfBag(foodProduct);
            }
            int temp = this.CountSpoiledProducts();
            for (int i = 0; i < foodProducts.Count(); i++) {
                this.bag.Remove(PeekUpTheProduct());
            }
            return temp;
        }
    }
}
