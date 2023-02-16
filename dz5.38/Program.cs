// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] GetArray(double size, double minValue, double maxValue)
{
    double[] array = new double[6];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(1, 100)) / 1;

    }
    return array;
}

double[] array = GetArray(4, 0, 21);
Console.WriteLine(String.Join(", ", array));

double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}

Console.WriteLine("Разность между максимальным и минимальным = {0}", max - min);



