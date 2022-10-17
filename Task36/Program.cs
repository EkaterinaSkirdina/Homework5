/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечетных позициях.*/

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(size*-1,size);
    }
    return array;
}

void PrintArray(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]} ");
    }
}

int SumOddNum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2==1)
        {
            sum+=arr[i];
        }
    }
    return sum;
}
int[] array = FillArray(10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(SumOddNum(array));