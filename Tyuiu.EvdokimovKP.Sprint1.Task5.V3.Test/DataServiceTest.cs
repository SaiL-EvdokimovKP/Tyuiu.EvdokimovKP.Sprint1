using Tyuiu.EvdokimovKP.Sprint1.Task5.V3.Lib;

namespace Tyuiu.EvdokimovKP.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int k = int.Parse("123456");
            DataService ds = new DataService();
            int h = ds.Calculate(k);
            int result = Convert.ToInt32(h);
            int wait = 4;
            Assert.AreEqual(wait, result);
        }
    }
}
