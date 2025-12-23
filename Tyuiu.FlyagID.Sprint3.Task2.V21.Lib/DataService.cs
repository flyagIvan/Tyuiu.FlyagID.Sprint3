using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FlyagID.Sprint3.Task2.V21.Lib
{
    public class DataService : ISprint3Task2V21
    {
        public double GetSumSeries(double x, int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;

            do
            {
                sum += Math.Pow(1 / (Math.Sin(k) + 2 * Math.Pow(x, k)), k);
                k++;
            }
            while (k <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}
