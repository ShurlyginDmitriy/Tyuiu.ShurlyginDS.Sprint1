    using Tyuiu.ShurlyginDS.Sprint1.Task5.V2.Lib;

namespace Tyuiu.ShurlyginDS.Sprint1.Task5.V2
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Шурлыгин Дмитрий Сергеевич // ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ.                                                                *");
            Console.WriteLine("* Дано значение температуры в градусах Фаренгейта. Определить значение    *");
            Console.WriteLine("* этой же температуры в градусах Цельсия.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double temp;
            

            Console.WriteLine("Введите температуру в градусах Фаренгейта: ");
            temp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Ответ: " + ds.FahrenheitToСelsius(temp));
            Console.ReadLine();
        }
    }
}
