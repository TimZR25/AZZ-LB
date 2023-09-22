using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LB_1;

namespace LB_1Test
{
    [TestClass]
    public class TestBag
    {
        private Bag bag;

        [TestMethod]
        public void TestAdd()
        {
            bag = new Bag("TestBag", 1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => bag.AddProduct(new FoodProduct("Яблоко", 3, 45, 60, 10, 10)));
        }

        [TestMethod]
        public void TestWeight()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Bag("TestBag", -6));
        }

        [TestMethod]
        public void TestName()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Bag("", 6));
        }

        [TestMethod]
        public void TestGet()
        {
            bag = new Bag("A", 6);
            bag.AddProduct(new FoodProduct("B", 1, 46, 78, 10, 10));
            Assert.IsNull(bag.GetProduct("A"));
        }

        [TestMethod]
        public void TestGet2()
        {
            bag = new Bag("A", 6);
            bag.AddProduct(new FoodProduct("B", 1, 46, 78, 10, 10));
            Assert.AreEqual("B", bag.GetProduct("B").Name);
        }

        [TestMethod]
        public void TestGetSpoiled()
        {
            bag = new Bag("A", 6);
            bag.AddProduct(new FoodProduct("B", 1, 9, 10, -1, 10));
            bag.AddProduct(new FoodProduct("C", 1, 100, 30, 0, 10));
            Assert.AreEqual(2, bag.GetSpoiledProductsCount());
        }

        [TestMethod]
        public void TestGetPossibleSpoiled()
        {
            bag = new Bag("A", 6);
            bag.AddProduct(new FoodProduct("B", 1, 9, 10, -1, 10));
            bag.AddProduct(new FoodProduct("C", 1, 80, 10, 0, 10));
            List<FoodProduct> list = new List<FoodProduct>();
            list.Add(new FoodProduct("D", 1, 0, 1, -1, 1));
            list.Add(new FoodProduct("E", 1, 0, 1, -1, 1));
            Assert.AreEqual(4, bag.GetPossibleSpoiledProductsCount(list));
        }
    }
}
