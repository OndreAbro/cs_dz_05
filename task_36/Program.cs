// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray()
{
    int size = new Random().Next(5, 15);
    var arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("Массив случайных чисел: [" + string.Join(", ", array) + "]");
}

int SumEvenPos(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

int[] myArray = CreateArray();
PrintArray(myArray);
Console.WriteLine($"Cумма элементов на четных позициях: {SumEvenPos(myArray)}");

