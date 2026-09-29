using Tyuiu.ShurlyginDS.Sprint1.Task6.V1.Lib;

namespace Tyuiu.ShurlyginDS.Sprint1.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 // Выполнил: Шурлыгин Д.С. // ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Шурлыгин Дмитрий Сергеевич // ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ.                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит код введенного пользователем символа*");
            Console.WriteLine("* Программа должна завершать работу в результате ввода, например, точки.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите символ и нажмите <Enter>. ");
            Console.WriteLine("Для завершения введите точку. ");

            while (true)
            {
                string str = Console.ReadLine();

                if (str == ".")
                {
                    break;
                }

                Console.WriteLine("Символ: " + str + ", Код: " + ds.SymbolCode(str));
            }

        }
    }
}

