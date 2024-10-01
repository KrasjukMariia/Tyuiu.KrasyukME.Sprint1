using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KrasyukME.Sprint1.Task0.V7.Lib
{
    public class DataService : ISprint1Task1V7
    {

        public double Calculate(double x, double y)
        {
            return (5 * x) / (y + x);
        }

        public double Calculate()
        {
            throw new NotImplementedException();
        }
    }
}