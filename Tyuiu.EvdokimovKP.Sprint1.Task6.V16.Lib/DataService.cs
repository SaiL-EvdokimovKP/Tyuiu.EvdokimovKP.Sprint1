using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.EvdokimovKP.Sprint1.Task6.V16.Lib
{
    public class DataService : ISprint1Task6V16
    {
        public bool CheckSpecSymbols(string value)
        {
            bool x = value.Contains("!");
            bool y = value.Contains("?");
            if (x && y)

                return true;

            else

                return false;
        }
    }
}
