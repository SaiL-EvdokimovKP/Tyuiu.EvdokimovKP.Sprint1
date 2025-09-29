using Tyuiu.EvdokimovKP.Sprint1.Task3.V7.Lib;

namespace Tyuiu.EvdokimovKP.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double verst = 1.0668;
            verst.ToString("F3");
            var res = ds.VerstsToKilometers(verst);
            Assert.AreEqual(106.68, res);
        }
    }
}

