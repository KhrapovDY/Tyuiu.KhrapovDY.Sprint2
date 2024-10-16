﻿using Tyuiu.KhrapovDY.Sprint2.Task5.V5.Lib;

namespace Tyuiu.KhrapovDY.Sprint2.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                          *");
            Console.WriteLine("* Тема: Оператор switch                                                                                              *");
            Console.WriteLine("* Задание #5                                                                                                         *");
            Console.WriteLine("* Вариант #5                                                                                                         *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                                                      *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуемое значение и возвращает результат.        *");
            Console.WriteLine("* Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства: «валету» — 11,     *");
            Console.WriteLine("* «даме» — 12, «королю» — 13, «тузу» — 14.                                                                           *");
            Console.WriteLine("* Порядковые номера остальных карт соответствуют их названиям («шестерка», «девятка» и т. п.).                       *");
            Console.WriteLine("* По заданному номеру карты k (6 <=k <= 14) определить достоинство соответствующей карты.                            *");
            Console.WriteLine("*                                                                                                                    *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine("Введите номер карты: ");
            int k = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((k < 4) || (k > 14))
            {
                res = "Введено неверное значение: ";
            }
            else
            {
                res = "Эта карта: " + ds.FindCardValue(k);
            }
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}