// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine());
int k = 1;
while (num > 999)
{
    num = num / 10;
}

if (num > 99)
{
    num = num % 10;
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Число не содержит третью цифру");
}
return 0;
