// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int NumberSum(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return 1;
    }
    sum = sum + (m++);
    return NumberSum(m, n, sum);
}

Console.Clear();
Console.Write("Введите начальное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите начальное число N: ");
int n = int.Parse(Console.ReadLine()!);
NumberSum(m, n, 0);