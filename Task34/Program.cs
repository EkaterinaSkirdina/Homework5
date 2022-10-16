/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество четных чисел в массиве.*/

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int EvenNum(int[] arg)
{
    int count = 0;
    foreach (int el in arg)
    {
        if (el%2==0)
        {
            count+=1;
        }
    }
    return count;
}

int [] array = GetArray(4);
PrintArray(array);
Console.WriteLine();
Console.Write(EvenNum(array));