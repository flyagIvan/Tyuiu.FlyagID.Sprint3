using Tyuiu.FlyagID.Sprint3.Task6.V28.Lib;

Console.Title = "Спринт #3 | Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #28                                                             *");
Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Найти среди целых чисел на отрезке [13, 19] количество всех делителей   *");
Console.WriteLine("* меньше 7                                                               *");
Console.WriteLine("***************************************************************************");

int startValue = 13;
int stopValue = 19;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.GetCountDivisors(startValue, stopValue);

Console.WriteLine($"Количество делителей меньше 7 = {result}");
Console.ReadLine();
