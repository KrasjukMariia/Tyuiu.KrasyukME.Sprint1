using Tyuiu.KrasyukME.Sprint1.Task0.V7.Lib;

namespace Tyuiu.KrasyukME.Sprint1.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5 , res);
        }
    }
}