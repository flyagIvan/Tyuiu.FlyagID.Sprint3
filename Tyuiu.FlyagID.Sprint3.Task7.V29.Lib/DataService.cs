using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FlyagID.Sprint3.Task7.V29.Lib
{
    public class DataService : ISprint3Task7V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] values = new double[len];

            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Abs(Math.Cos(x)) < 0.0001)
                {
                    values[i] = 0;
                }
                else
                {
                    double fx = (2 * x - 3 / Math.Cos(x) - 2 * x) + 5 * x - 6;
                    values[i] = Math.Round(fx, 2);
                }
                i++;
            }

            return values;
        }
    }
}
