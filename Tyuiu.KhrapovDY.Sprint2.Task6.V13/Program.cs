using Tyuiu.KhrapovDY.Sprint2.Task6.V13.Lib;

namespace Tyuiu.KhrapovDY.Sprint2.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Получение результата из switch                                              *");
            Console.WriteLine("* Задание #6                                                                        *");
            Console.WriteLine("* Вариант #13                                                                       *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора switch  *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными числами:          *");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m            *");
            Console.WriteLine("* определить дату следующего дня. Заданный год является високосным.                 *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Введите номер дня: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер года: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine(ds.FindDateOfNextDay(g, m, n));

            Console.ReadKey();

        }
    }
}