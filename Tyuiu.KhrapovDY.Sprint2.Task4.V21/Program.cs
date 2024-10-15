using Tyuiu.KhrapovDY.Sprint2.Task4.V21.Lib;

namespace Tyuiu.KhrapovDY.Sprint2.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                          *");
            Console.WriteLine("* Тема: Тернарный оператор                                                           *");
            Console.WriteLine("* Задание #4                                                                         *");
            Console.WriteLine("* Вариант #21                                                                        *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                      *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                           *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием          *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменной x, y с           *");
            Console.WriteLine("* с клавиатуры. Если x< y-2, то z = (2 + x+1 / x^2)^y иначе x^2+10 / y^2-(sin x)^2+12*");
            Console.WriteLine("*                                                                                    *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);


            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}