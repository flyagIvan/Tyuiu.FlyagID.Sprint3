using Tyuiu.FlyagID.Sprint3.Task3.V8.Lib;

Console.Title = "Спринт #3 | Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Используя цикл foreach удалить все буквы и знаки препинания, оставить   *");
Console.WriteLine("* цифры и преобразовать в число                                           *");
Console.WriteLine("* Строка: vc,x12fc fc!e                                                    *");
Console.WriteLine("***************************************************************************");

string value = "vc,x12fc fc!e";
Console.WriteLine($"Исходная строка: '{value}'");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.ConvertStringToInt(value);

Console.WriteLine($"Полученное число: {result}");
Console.ReadLine();
