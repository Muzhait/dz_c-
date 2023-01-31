// Задача 15: Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.

Console.Clear();

Console.WriteLine("Введите день недели узнать выходной этот день или нет: ");
int a = int.Parse(Console.ReadLine()!);

if (a == 6 || a == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}