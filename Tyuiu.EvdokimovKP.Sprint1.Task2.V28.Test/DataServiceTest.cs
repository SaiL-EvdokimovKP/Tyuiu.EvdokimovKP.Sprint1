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
            int x = 1;
            var res = (int)(273 + x);
            Assert.AreEqual(274, res);
        }
    }
}

