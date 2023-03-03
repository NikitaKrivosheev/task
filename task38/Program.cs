// 38. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным 
// элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] ArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("Элементы в массиве [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{Math.Round(arr[i], 1)} | ");
        else
            Console.Write($"{Math.Round(arr[i], 1)}");
    }
    Console.WriteLine("]");
}

double SearchMaxNumbers(double[] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}

double SearchMinNumbers(double[] arr)
{
    int i = 0;
    double min = arr[i];
    while (i < arr.Length)
    {
        if (arr[i] < min)
            min = arr[i];
        i++;
    }
    return min;
}

double DifferenceMaxMin(double num, double num2)
{
    double Difference = num - num2;
    return Difference;
}

double[] array = ArrayRndDouble(10, 1, 100);
PrintArrayDouble(array);
double maxNum = SearchMaxNumbers(array);
double minNum = SearchMinNumbers(array);
double differenceMaxMin = DifferenceMaxMin(maxNum, minNum);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(differenceMaxMin, 1)}");
// MidpointRounding.ToZero