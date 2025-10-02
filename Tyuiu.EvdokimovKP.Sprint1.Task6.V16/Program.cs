using Tyuiu.EvdokimovKP.Sprint1.Task6.V16.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Евдокимов К. П. | ПКТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Евдокимов Кирилл Петрович | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("*  вычисляет результат по формуле и печатает результат на экране.         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
Console.WriteLine("***************************************************************************");

string value;
Console.WriteLine("Введите текст");
value = Console.ReadLine();

if (ds.CheckSpecSymbols(value))

    Console.WriteLine("В тексте есть и восклицание, и вопрос!");

else

    Console.WriteLine("В тексте отсутствует один из символов: ! или ?");

Console.WriteLine();
Console.ReadLine();