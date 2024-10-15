using Tyuiu.KhrapovDY.Sprint2.Task2.V29.Lib;

namespace Tyuiu.KhrapovDY.Sprint2.Task2.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";
            //Длина строки 75 символов
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                                *");
            Console.WriteLine("* Задание #2                                                                        *");
            Console.WriteLine("* Вариант #29                                                                       *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и вычисляет,  *");
            Console.WriteLine("* находится ли точка с координатами X, Y в заштрихованной области.                  *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение координаты X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение координаты Y:");
            y = Convert.ToInt32(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находиться в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находиться в заштрихованной области");
            }
        }
    }
}