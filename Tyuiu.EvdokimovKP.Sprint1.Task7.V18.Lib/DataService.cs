using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.EvdokimovKP.Sprint1.Task7.V18.Lib
{
    public class DataService : ISprint1Task7V18
    {
        public double Calculate(double x, double y)
        {
            double chis = (1 + Math.Pow(Math.Sin(x + y), 2));
            double znamNotModul = x - (2 * x) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2));
            double znamModul = Math.Abs(znamNotModul);
            double PlusZnamModul = 2 + znamModul;
            double drob = chis / PlusZnamModul + x;
            double z = Math.Round(drob, 3);
            return z;
        }
    }
}
