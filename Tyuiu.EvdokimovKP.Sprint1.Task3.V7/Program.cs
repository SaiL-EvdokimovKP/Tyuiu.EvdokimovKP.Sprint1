using Tyuiu.EvdokimovKP.Sprint1.Task3.V7.Lib;

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
Console.WriteLine("* Написать программу, которая пересчета расстояния из верст в километры   *");
Console.WriteLine("* и печатает результат на экране.                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double verst;
Console.WriteLine("Введите расстояние в верстах –>");
verst = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
Console.WriteLine("***************************************************************************");

Console.WriteLine(+ds.VerstsToKilometers(verst));
Console.ReadLine();
