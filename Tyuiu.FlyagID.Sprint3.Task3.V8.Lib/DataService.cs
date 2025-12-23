using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FlyagID.Sprint3.Task3.V8.Lib
{
    public class DataService : ISprint3Task3V8
    {
        public int ConvertStringToInt(string value)
        {
            string digits = "";

            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    digits += c;
                }
            }

            return int.Parse(digits);
        }
    }
}
