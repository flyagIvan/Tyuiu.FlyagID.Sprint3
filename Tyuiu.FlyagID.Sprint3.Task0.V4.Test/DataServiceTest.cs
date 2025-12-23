using Tyuiu.FlyagID.Sprint3.Task0.V4.Lib;
namespace Tyuiu.FlyagID.Sprint3.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int x, y;
            x = 1;
            y = 7;
            Assert.AreEqual(6482.439, ds.GetMultiplySeries(x, y));

        }
    }
}