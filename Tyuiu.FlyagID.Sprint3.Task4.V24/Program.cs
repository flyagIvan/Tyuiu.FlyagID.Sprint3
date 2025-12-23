using Tyuiu.FlyagID.Sprint3.Task4.V24.Lib;
Console.Title = "Спринт #3 | Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Использование операторов break и continue в циклах               *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #24                                                             *");
Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* На отрезке от -5 до 5 вычислить значение функции                        *");
Console.WriteLine("* y = (sin(x) / x) + 2. При x = 0 прервать цикл.                          *");
Console.WriteLine("* Полученные значения перемножать.                                        *");
Console.WriteLine("***************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.Calculate(startValue, stopValue);

Console.WriteLine($"Произведение значений функции = {result}");
Console.ReadLine();
