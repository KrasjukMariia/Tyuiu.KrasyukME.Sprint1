using System.Globalization;
using  tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;


namespace Tyuiu.KrasyukME.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {

            string[] words = value.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Перемещение последней буквы каждого слова в начало
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0) // Проверка на наличие букв в слове
                {
                    char lastChar = words[i][words[i].Length - 1]; // Получаем последнюю букву
                    string modifiedWord = lastChar + words[i].Substring(0, words[i].Length - 1); // Формируем новое слово
                    words[i] = modifiedWord; // Заменяем слово в массиве
                }
            }

            // Возвращение всех модифицированных слов в виде строки, разделенной пробелами
            return string.Join(" ", words);
        }

        
    }
}
