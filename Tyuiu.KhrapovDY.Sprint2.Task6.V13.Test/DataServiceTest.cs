using Tyuiu.KhrapovDY.Sprint2.Task6.V13.Lib;

namespace Tyuiu.KhrapovDY.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            string res = "03.12.2022";
            int g = 2022;
            int m = 12;
            int n = 03;
            Assert.AreEqual(res, ds.FindDateOfNextDay(g, m, n));
        }
    }
}