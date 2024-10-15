using Tyuiu.KhrapovDY.Sprint2.Task2.V29.Lib;

namespace Tyuiu.KhrapovDY.Sprint2.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckInShadedArea()
        {
            DataService ds = new DataService();
            int x = 13;
            int y = 6;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}