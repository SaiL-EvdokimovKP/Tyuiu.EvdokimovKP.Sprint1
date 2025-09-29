using Tyuiu.EvdokimovKP.Sprint1.Task4.V13.Lib;

namespace Tyuiu.EvdokimovKP.Sprint1.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = -(x);
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1/6, res);
        }
    }
}
