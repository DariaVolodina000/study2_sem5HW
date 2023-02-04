// Задача 1: Задайте массив заполненный случайными 
// положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(99, 1000);
    }
}

void PrintArray(int[] arr) 
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.WriteLine();
        Console.Write(arr[j]);
    }
    Console.WriteLine();
}

int [] array = new int [10];
FillArray(array);
PrintArray(array);

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    {
        sum++;
    }
}


Console.WriteLine($"В заданном массиве четных чисел > {sum}");
