// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray()
{
    int size = new Random().Next(5, 15);
    var arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("Массив трехзначных положительных чисел: [" + string.Join(", ", array) + "]");
}

int CountEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result += 1;
        }
    }
    return result;
}

int[] myArray = CreateArray();
PrintArray(myArray);
Console.WriteLine($"Количество четных чисел в массиве: {CountEven(myArray)}");
