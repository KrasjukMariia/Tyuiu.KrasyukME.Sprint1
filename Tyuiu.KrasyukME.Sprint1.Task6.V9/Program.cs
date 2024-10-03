
using Tyuiu.KrasyukME.Sprint1.Task6.V9.Lib;
namespace Tyuiu.KrasyukME.Sprint1.Task6.V9
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
            Console.WriteLine("*                              Задание #6                                 *");
            Console.WriteLine("*                              Вариант #9                                 *");
            Console.WriteLine("* Выполнил: Красюк Мария Евгеньевна    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("* Напечатать все слова, перенеся их последнюю букву в начало.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               Введите текст::                          *");
            Console.WriteLine("***************************************************************************");

            string input = Console.ReadLine();

            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(ds.MoveLetterToStart(input));
        }
        
    }
}