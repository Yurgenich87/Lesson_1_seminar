/* Задача 4: Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите первое число: ");
string a1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string b1 = Console.ReadLine();
Console.WriteLine("Введите третье число: ");
string d1 = Console.ReadLine();

int a = Convert.ToInt32(a1);
int b = Convert.ToInt32(b1);
int d = Convert.ToInt32(d1);
int max = a;

if (a > b) max = a;
if (a < b) max = b;
if (d > max) max = d;
if (d < max) max = max;

Console.Write("max = ");
Console.WriteLine(max);