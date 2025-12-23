using Tyuiu.FlyagID.Sprint3.Task1.V18.Lib;

Console.Title = "Спринт #3 | Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла while                                              *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("*     15                                                                  *");
Console.WriteLine("* S = Σ sin(i) * (1/4)^2                                                   *");
Console.WriteLine("*    i=1                                                                  *");
Console.WriteLine("***************************************************************************");

int startValue = 1;
int stopValue = 15;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.GetSumSeries(startValue, stopValue);

Console.WriteLine($"Сумма ряда = {result}");
Console.ReadLine();
