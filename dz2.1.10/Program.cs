// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введите трезначное число: ");
int a = int.Parse(Console.ReadLine()!);
int b = ((a / 10) % 10);

Console.WriteLine(b);