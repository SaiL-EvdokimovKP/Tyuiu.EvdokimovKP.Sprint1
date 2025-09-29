using Tyuiu.EvdokimovKP.Sprint1.Task1.V10.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Евдокимов К. П. | ПКТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Евдокимов Кирилл Петрович | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет выражение (x + y) / (1 + x)       *");
Console.WriteLine("* и печатает результат на экране.                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* (x + y) / (1 + x)                                                       *");

double x, y;
Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(x, y));

Console.ReadLine();
