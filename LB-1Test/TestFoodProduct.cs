using LB_1;

namespace LB_1Test
{
    [TestClass]
    public class TestFoodProduct
    {

        private FoodProduct testFoodProduct;

        [TestMethod]
        public void TestTemperature()
        {
            testFoodProduct = new FoodProduct("3", 37, 56, 70, 10, 23);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testFoodProduct.Temperature = 700);
        }

        [TestMethod]
        public void TestMaxTemperature()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new FoodProduct("3", 37, 56, 7000, 10, 23));
        }

        [TestMethod]
        public void TestMinTemperature()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new FoodProduct("3", 37, 56, 50, -1000, 23));
        }

        [TestMethod]
        public void TestWeight() {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new FoodProduct("3", -37, 56, 70, 10, 23));
        }

        [TestMethod]
        public void TestName()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new FoodProduct("", 37, 56, 70, 10, 23));
        }

        [TestMethod]
        public void TestHeatCapacity()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new FoodProduct("", 37, 56, 70, 10, -23));
        }

        [TestMethod]
        public void TestTransfer()
        {
            testFoodProduct = new FoodProduct("3", 37, 56, 70, 10, 10);
            testFoodProduct.TransferThermalEnergy(20);
            Assert.AreEqual(2, testFoodProduct.Temperature);

        }
    }
}