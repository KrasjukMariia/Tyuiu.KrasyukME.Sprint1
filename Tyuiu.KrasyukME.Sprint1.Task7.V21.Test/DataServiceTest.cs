using Tyuiu.KrasyukME.Sprint1.Task7.V21.Lib;
namespace Tyuiu.KrasyukME.Sprint1.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(13.377, res);
        }
    }
}