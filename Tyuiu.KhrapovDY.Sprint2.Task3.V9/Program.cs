using Tyuiu.KhrapovDY.Sprint2.Task3.V9.Lib;

namespace Tyuiu.KhrapovDY.Sprint2.Task3.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                          *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                                *");
            Console.WriteLine("* Задание #3                                                                         *");
            Console.WriteLine("* Вариант #9                                                                         *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                      *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                           *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с использованием*");
            Console.WriteLine("* вложенных оператор if-else, где пользователь вводит значение переменной X с        *");
            Console.WriteLine("* с клавиатуры. Округлить полученное значение до трех знаков после запятой;          *");
            Console.WriteLine("*                                                                                    *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();

        }
    }
}