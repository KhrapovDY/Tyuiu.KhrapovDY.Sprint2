using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KhrapovDY.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((y >= x) && (y >= -x)) && (((x >= -Math.Sqrt(2) / 2) && (x <= Math.Sqrt(2) / 2)) && ((y >= 0) && (y <= 1))))
                res = true;
            else
                res = false;
            return res;
        }
    }
}