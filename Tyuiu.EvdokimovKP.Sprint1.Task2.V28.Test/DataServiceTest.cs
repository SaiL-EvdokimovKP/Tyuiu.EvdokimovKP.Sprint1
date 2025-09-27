using Tyuiu.EvdokimovKP.Sprint1.Task2.V28.Lib;

namespace Tyuiu.EvdokimovKP.Sprint1.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            var res = ds.Calculate(x);
            Assert.AreEqual( 274.0 , res);
        }
    }
}
