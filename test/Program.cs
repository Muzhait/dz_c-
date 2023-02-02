// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()!);

while (number > 999)
{
    number = number / 10;
}

if (number < 99)
{
    Console.WriteLine($"There is no third number"!);
}
else
{
    number = number % 10;
    Console.WriteLine(number);
}