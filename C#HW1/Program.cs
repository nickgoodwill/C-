﻿// Напишите программу, которая на вход принимает два числа и выдаёт, 
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