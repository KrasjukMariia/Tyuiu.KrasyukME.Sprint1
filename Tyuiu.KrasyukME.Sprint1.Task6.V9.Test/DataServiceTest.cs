
using Tyuiu.KrasyukME.Sprint1.Task6.V9.Lib;
namespace Tyuiu.KrasyukME.Sprint1.Task6.V9.Test
    

{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            DataService ds  = new DataService();
            Assert.AreEqual("нпо кко", ds.MoveLetterToStart("пон кок"));
        }

    }
}
