using Tyuiu.DanilovAS.Sprint5.Task4.V13.Lib;

namespace Tyuiu.DanilovAS.Sprint5.Task4.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Данилов А. С. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич |  ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt. Прочитать значение  *");
            Console.WriteLine("* из файла и подставить вместо Х в формуле. Вычислить значение по формуле *");
            Console.WriteLine("* Округлить до трёх знаков после запятой и вернуть результат на консоль   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* path = С:\\DataSprint5\\InPutDataFileTask4V0.txt                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"С:\DataSprint5\InPutDataFileTask4V13.txt";
            Console.WriteLine($"Данные находятся в файле {path}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
