// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число и узнайте является ли оно палиндромом: ");
int number = int.Parse(Console.ReadLine()!);
int number1 = number;
int result = 0;

while (number > 0)
{
    result = result * 10;
    result = result + (number % 10);
    number = number / 10;
}

if (number1 == result)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}