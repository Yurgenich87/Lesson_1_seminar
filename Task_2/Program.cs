/* Задача 2: Напишите программу, которая на вход принимает 
два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите первое число: ");
string a1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string b1 = Console.ReadLine();

int a = Convert.ToInt32(a1);
int b = Convert.ToInt32(b1);
int max = a;

if (a > b) max = a;
if (a < b) max = b;

Console.Write("max = ");
Console.WriteLine(max);