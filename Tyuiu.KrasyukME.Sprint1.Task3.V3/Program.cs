using Tyuiu.KrasyukME.Sprint1.Task3.V3.Lib;
namespace Tyuiu.KrasyukME.Sprint1.Task3.V3
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
            Console.WriteLine("*                              Задание #3                                 *");
            Console.WriteLine("*                              Вариант #3                                 *");
            Console.WriteLine("* Выполнил: Красюк Мария Евгеньевна    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("* Написать программу вычисления объема параллелепипеда.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");



            double length, width, height;
            Console.WriteLine("Введите значение длины ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение ширины ");
            width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение высоты ");
            height = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.ParallelepipedVolume(length, width, height));
            Console.ReadLine();


        }
    }
}