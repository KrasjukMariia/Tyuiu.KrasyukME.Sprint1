using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KrasyukME.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double f)
        {
            return Convert.ToInt32 (5 * (f - 32)) / 9;
        }
        
    }
}
