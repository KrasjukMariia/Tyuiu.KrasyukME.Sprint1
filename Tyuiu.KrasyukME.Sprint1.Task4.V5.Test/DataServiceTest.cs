using Tyuiu.KrasyukME.Sprint1.Task4.V5.Lib;
namespace Tyuiu.KrasyukME.Sprint1.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
                DataService ds = new DataService();
                double  x= 6;
                double y = 4;
             
                var res = ds.Calculate(x, y);
                Assert.AreEqual(0.125, res);
        }
    }
}