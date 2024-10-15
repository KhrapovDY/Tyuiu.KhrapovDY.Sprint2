using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KhrapovDY.Sprint2.Task1.V2.Lib
{
    public class DataService : ISprint2Task1V2
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d); //true
            res[1] = (a + 22 > b) & (c < d); //true
            res[2] = (a > b) || (c < d); //true
            res[3] = (a + 22 > b) && (c < d); //true
            res[4] = !(!res[0]); //true
            res[5] = (a + 22 > b) ^ (c < d); //false

            return res;

        }
    }
}