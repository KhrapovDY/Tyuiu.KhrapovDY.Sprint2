﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KhrapovDY.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y > x) && (y > -x) && (y < Math.Sqrt(1 - Math.Pow(x, 2))))
                res = true;
            else
                res = false;
            return res;
        }
    }
}
