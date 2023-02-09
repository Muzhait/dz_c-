// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int positiveCount(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] array = GetArray(6, 100, 1000);
Console.WriteLine(String.Join(", ", array));

int posCount = positiveCount(array);
Console.WriteLine($"Количество четных чисел в массиве равна {posCount}");