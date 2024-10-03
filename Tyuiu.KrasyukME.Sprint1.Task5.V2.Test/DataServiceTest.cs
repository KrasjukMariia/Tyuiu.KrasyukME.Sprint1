using Tyuiu.KrasyukME.Sprint1.Task5.V2.Lib;
namespace Tyuiu.KrasyukME.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double f = 80;


            var res = ds.FahrenheitTo—elsius(f);
            Assert.AreEqual(26, res);
        }
    }
}