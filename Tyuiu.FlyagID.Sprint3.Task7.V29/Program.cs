using Tyuiu.FlyagID.Sprint3.Task7.V29.Lib;

Console.Title = "Спринт #3 | Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1";
Console.WriteLine("************************************************************");
Console.WriteLine("* Спринт #3                                                *");
Console.WriteLine("* Тема: Табулирование функции                             *");
Console.WriteLine("* Задание #7                                              *");
Console.WriteLine("* Вариант #28                                             *");
Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1               *");
Console.WriteLine("************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Табулировать функцию                                   *");
Console.WriteLine("* f(x) = (2x - 3 / cos(x) - 2x) + 5x - 6                  *");
Console.WriteLine("* на диапазоне [-5, 5] с шагом 1                          *");
Console.WriteLine("************************************************************");

int startValue = -5;
int stopValue = 5;

DataService ds = new DataService();
double[] result = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("+----------+-----------+");
Console.WriteLine("|    x     |   f(x)    |");
Console.WriteLine("+----------+-----------+");

for (int i = 0; i < result.Length; i++)
{
    int x = startValue + i;
    Console.WriteLine($"| {x,5}    | {result[i],8:F2} |");
}

Console.WriteLine("+----------+-----------+");
Console.ReadLine();
