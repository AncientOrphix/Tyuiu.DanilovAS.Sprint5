using Tyuiu.DanilovAS.Sprint5.Task1.V14.Lib;

namespace Tyuiu.DanilovAS.Sprint5.Task1.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Данилов А. С. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File.Запись набора данных в текстовый файл                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич |  ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, произвести табулирование на заданном диапазоне [-5; 5] с  *");
            Console.WriteLine("* шагом 1. Произвести проверку деления на ноль. При деление на ноль       *");
            Console.WriteLine("* вернуть значение 0. Результат сохранить в текстовый файл OutPutFileTask1*");
            Console.WriteLine("* и вывести на консоль в таблицу. Значения округлить до двух знаков после *");
            Console.WriteLine("* запятой.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine($"Файл {result} создан!");
            Console.ReadKey();
        }
    }
}
