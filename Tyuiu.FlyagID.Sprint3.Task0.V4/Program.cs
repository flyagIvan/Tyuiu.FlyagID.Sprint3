using Tyuiu.FlyagID.Sprint3.Task0.V4.Lib;
namespace Tyuiu.TsarevDI.Sprint3.Task0.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Фляг И. Д. | СМАРТб-24-1";
            Console.WriteLine("**");
            Console.WriteLine(" Спринт #3                                                             ");
            Console.WriteLine(" Тема: Оператор цикла for                                              ");
            Console.WriteLine(" Задание #0                                                            ");
            Console.WriteLine(" Варинат #4                                                            ");
            Console.WriteLine(" Выполнил: Фляг Иван Дмитриевич | СМАРТб-24-1                            ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                              ");
            Console.WriteLine(" Написать программу используя цикл for, которая вычисляет произведение ");
            Console.WriteLine(" ряда по формуле.                                                      ");
            Console.WriteLine("                                                                       ");
            Console.WriteLine("**");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     ");
            Console.WriteLine("**");
            int startValue, stopValue;
            Console.WriteLine("startValue = 1");
            Console.WriteLine("stopValue = 7");
            startValue = 1;
            stopValue = 7;
            Console.WriteLine("**");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                            ");
            Console.WriteLine("**");
            Console.WriteLine(ds.GetMultiplySeries(startValue, stopValue));
            Console.ReadKey();

        }
    }
}
