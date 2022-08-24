// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size)
{
    int[] array = new int[size];
    var random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(1, 99);
        Console.Write(array[i] + " ");
    }
    return array;
}

int SumOddElements (int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 !=0) Sum += array[i];
    }
    return Sum;
}

int [] array = CreateArray(4);
Console.WriteLine("Сумма элементов, стоящих на нечетной позиции: " + SumOddElements(array));