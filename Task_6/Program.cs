﻿/* Задача 6: Напишите программу, которая на вход принимает число 
и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число: ");
string aferst = Console.ReadLine();

int a = Convert.ToInt32(aferst);

if (a % 2 == 0)
{
	Console.WriteLine("четное число");
}
else
{
	Console.WriteLine("нечетное число");
}
