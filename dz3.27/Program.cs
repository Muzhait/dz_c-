// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int GetSum(int A)
{
    int sum = 0;
    for (int dig = 0; A > 0; A = A / 10)
    {
        dig = A % 10;
        sum = sum + dig;
    }
    return sum;
}


Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр числа {N} равна {GetSum(N)}");