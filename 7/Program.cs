


Console.WriteLine("Введите трехзначное число: ");

string nfirst = Console.ReadLine();
int n = Convert.ToInt32(nfirst);

if ((n >= 100) && (n <= 999)) ;
Console.WriteLine(n % 10);

else
	Console.WriteLine("Неверное число");

