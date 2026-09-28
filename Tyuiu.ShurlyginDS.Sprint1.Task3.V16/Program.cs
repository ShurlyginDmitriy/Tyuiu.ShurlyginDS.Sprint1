using Tyuiu.ShurlyginDS.Sprint1.Task3.V16.Lib;

namespace Tyuiu.ShurlyginDS.Sprint1.Task3.V16
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Шурлыгин Дмитрий Сергеевич // ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ.                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет и печатает коэффициент            *");
            Console.WriteLine("* приведенного квадратного уравнения, корнями которого являются           *");
            Console.WriteLine("* введенные пользователем два вещественных числа                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1;
            double x2;

            Console.WriteLine("Введите корень x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите корень x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Коэффициент: " + ds.CoeffOfQuadraticEquation(x1, x2));
            Console.ReadLine();
        }
    }
}
