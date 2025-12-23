using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FlyagID.Sprint3.Task6.V28.Lib
{
    public class DataService : ISprint3Task6V28
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;

            for (int num = startValue; num <= stopValue; num++)
            {
                for (int div = 1; div < 7; div++)
                {
                    if (num % div == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

    
    }
}
