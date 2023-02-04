// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,100);
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

int[] array = new int[4];
FillArray(array);
PrintArray(array);

int sum = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
Console.WriteLine($"Сумма числе стоящих на нечетных позициях > {sum}");
