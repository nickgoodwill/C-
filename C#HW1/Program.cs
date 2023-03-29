//2// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

int min = 0;
int max = 0;
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    max = a;
    min = b;
    Console.WriteLine("Первое число больше второго");
    Console.Write(max);Console.Write(", "); Console.Write(min);
}
else
{
    max = b;
    min = a;
    Console.WriteLine("Второе число больше первого");
    Console.Write(max); Console.Write(", "); Console.Write(min);
}

//4// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

int max = 0;
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (max > c)
{
    Console.WriteLine("Максимальное число: ");
    Console.Write(max);
}
else
{
    max = c;
    Console.WriteLine("Максимальное число: ");
    Console.Write(max);
}

//6// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
double a = double.Parse(Console.ReadLine());

if (a % 2 == 0)
{
    Console.Write(a);
    Console.WriteLine(" - Четное число");
}
else
{
    Console.Write(a);
    Console.WriteLine(" - Нечетное число");
}

//8// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число: ");
int n = int.Parse(Console.ReadLine());

if (n > 1)
{
    for (int res = 2; res <= n; res = res + 2)
    {
            Console.Write(res); Console.Write(" ");  
    }
}
else
{
    Console.WriteLine("Нет четных чисел");
}