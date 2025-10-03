using Tyuiu.EvdokimovKP.Sprint1.Task7.V18.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Евдокимов К. П. | ПКТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Евдокимов Кирилл Петрович | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
Console.WriteLine("***************************************************************************");

double x;
Console.WriteLine("Введите значение X");
x = Convert.ToDouble(Console.ReadLine());

double y;
Console.WriteLine("Введите значение Y");
y = Convert.ToDouble(Console.ReadLine());

double z = ds.Calculate(x, y);
Console.WriteLine("z = " + z);