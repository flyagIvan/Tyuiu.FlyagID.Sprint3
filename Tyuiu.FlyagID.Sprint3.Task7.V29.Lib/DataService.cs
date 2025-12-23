using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FlyagID.Sprint3.Task7.V29.Lib
{
    public class DataService : ISprint3Task7V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) - 2 * x;

                if (Math.Abs(denominator) < 0.0001)
                {
                    result[index] = 0;
                }
                else
                {
                    double value = (2 * x - 3) / denominator + 5 * x - 6;
                    result[index] = Math.Round(value, 2);
                }

                index++;
            }

            return result;
        }
    }
}
