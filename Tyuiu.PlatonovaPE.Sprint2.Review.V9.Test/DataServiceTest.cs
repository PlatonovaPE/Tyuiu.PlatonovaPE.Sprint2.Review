using Tyuiu.PlatonovaPE.Sprint2.Review.V9.Lib;
namespace Tyuiu.PlatonovaPE.Sprint2.Review.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0.0;
            double y = 0.0;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}