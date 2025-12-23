using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FlyagID.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p, t;
            t = 1;
            for (startValue = 1; startValue <= stopValue; startValue++)
            {

                p = Math.Sin(0.1) + startValue;
                t *= p;
            }
            return Math.Round(t, 3);
        }
    }
}