using Tyuiu.KhrapovDY.Sprint2.Task3.V9.Lib;

namespace Tyuiu.KhrapovDY.Sprint2.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 23.12;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = -0.372;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 0;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = -17.5;
            Assert.AreEqual(wait, res);

        }
    }
}