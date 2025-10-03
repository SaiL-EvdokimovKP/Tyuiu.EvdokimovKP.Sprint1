using Tyuiu.EvdokimovKP.Sprint1.Task7.V18.Lib;

namespace Tyuiu.EvdokimovKP.Sprint1.Task7.V18.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 0.5;
            double y = 0.5;
            DataService ds = new DataService();
            double z = ds.Calculate(x, y);
            double wait = 1.2;
            Assert.AreEqual(wait, z);
        }
    }
}
