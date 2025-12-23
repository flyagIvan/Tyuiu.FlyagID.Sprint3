using Tyuiu.FlyagID.Sprint3.Task2.V21.Lib;

Console.Title = "Спринт #3 | Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла do...while                                         *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму   *");
Console.WriteLine("* ряда по формуле при x = 1,5                                              *");
Console.WriteLine("*     10                                                                  *");
Console.WriteLine("* S = Σ (1 / (sin(k) + 2 * x^k))^k                                         *");
Console.WriteLine("*    k=1                                                                  *");
Console.WriteLine("***************************************************************************");

double x = 1.5;
int startValue = 1;
int stopValue = 10;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.GetSumSeries(x, startValue, stopValue);

Console.WriteLine($"Сумма ряда = {result}");
Console.ReadLine();
