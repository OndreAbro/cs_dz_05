// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray()
{
    int size = new Random().Next(5, 15);
    var arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * new Random().Next(-100, 100), 2);
    }
    return arr;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("Массив вещественных чисел: [" + string.Join(", ", array) + "]");
}

double MaxMinDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    return Math.Round(max - min, 2);
}

double[] myArray = CreateArray();
PrintArray(myArray);
Console.WriteLine($"Разница между максимальным и минимальным элементами': {MaxMinDiff(myArray)}");
