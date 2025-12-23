using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint3.Task3.V8.Lib;

namespace Tyuiu.FlyagID.Sprint3.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();
            string value = "vc,x12fc fc!e";

            int result = ds.ConvertStringToInt(value);
            int expected = 12;

            Assert.AreEqual(expected, result);
        }
    }
}
