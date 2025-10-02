using Tyuiu.EvdokimovKP.Sprint1.Task6.V16.Lib;

namespace Tyuiu.EvdokimovKP.Sprint1.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string value = "привет!?";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols(value);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
