using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint3.Task7.V29.Lib;

namespace Tyuiu.FlyagID.Sprint3.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculation()
        {
            DataService ds = new DataService();

            int startValue = 0;
            int stopValue = 0;
            double[] result = ds.GetMassFunction(startValue, stopValue);

            double expected = -9;

            Assert.AreEqual(expected, result[0], 0.001);
        }
    }
}
