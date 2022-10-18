/* Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.*/

void Main()
{
double[] array = FillArray(10);
PrintArray(array);
double max = MaxValue(array);
double min = MinValue(array);
Console.WriteLine();
Console.WriteLine(DiffElements(max, min));
}

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

double MaxValue(double[] arr1)
{
    double maxVal = arr1[0];
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] > maxVal)
        {
            maxVal = arr1[i];
        }
    }
    return maxVal;
}

double MinValue(double[] arr2)
{
    double minVal = arr2[0];
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] < minVal)
        {
            minVal = arr2[i];
        }
    }
    return minVal;
}

double DiffElements(double arg1, double arg2)
{
    double result = 0;
    result = arg1 - arg2;
    return result;
}

Main();