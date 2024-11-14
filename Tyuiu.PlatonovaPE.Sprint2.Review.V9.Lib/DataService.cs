using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PlatonovaPE.Sprint2.Review.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y <= Math.Sin(x)) && (y <= 0.5) && (y >= 0))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
