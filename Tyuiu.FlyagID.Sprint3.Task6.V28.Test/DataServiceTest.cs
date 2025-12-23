using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint3.Task6.V28.Lib;

namespace Tyuiu.FlyagID.Sprint3.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCountDivisors()
        {
            DataService ds = new DataService();

            int startValue = 13;
            int stopValue = 13;

            int result = ds.GetSumTheDivisors(startValue, stopValue);
            int expected = 2;

            Assert.AreEqual(expected, result);
        }
    }
}
