using Tyuiu.KrasyukME.Sprint1.Task4.V5.Lib;
namespace Tyuiu.KrasyukME.Sprint1.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Красюк.М.Е. | ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #1                              *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("*                              Задание #4                                 *");
            Console.WriteLine("*                              Вариант #5                                 *");
            Console.WriteLine("* Выполнил: Красюк Мария Евгеньевна    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, " +
                              " вычисляет результат по формуле и печатает его на экране.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");



            double x, y;
            Console.WriteLine("Введите значение x ");
            x = Convert.ToDouble(Console.ReadLine());

            

            Console.WriteLine("Введите значение y ");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();

        }
    }
}
