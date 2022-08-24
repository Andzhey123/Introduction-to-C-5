//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreateArray(int size)
{
    int[] array = new int[size];
    var random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(100, 999);
        Console.Write(array[i] + " ");
    }
    return array;
}
void EvenNumbers(int[] array)
{
    Console.WriteLine();
    Console.Write("Количество четных элементов - ");
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    Console.Write(result);
}
int[] array = CreateArray(4);
EvenNumbers(array);