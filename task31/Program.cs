// 31. Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3, 9 , -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

//--------------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА

Console.Write("Введите количество элементов массива: ");
int digit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите промежуток между случайными числами от: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("До: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int num, int min, int max)
{
    Random rand = new Random();
    int[] arr = new int[num];
    int n = arr.Length;
    for (int i = 0; i < n; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int n = arr.Length;
    Console.Write("Элементы в массиве [");
    for (int i = 0; i < n; i++)
    {
        Console.Write(arr[i]);
        if (i < n - 1) Console.Write(", ");
    }
    Console.Write("] ");
}

void SumNumbers(int[] arr)
{
    int n = arr.Length;
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < n; i++)
    {
        if (arr[i] > 0)
            sumPos = sumPos + arr[i];
        else
            sumNeg = sumNeg + arr[i];
    }
    Console.WriteLine($"сумма положительных чисел = {sumPos}, сумма отрицательных = {sumNeg}.");
}

int[] array = RandomArray(digit, number, number2);
PrintArray(array);
SumNumbers(array);

//--------------------------------------------------------------------------------------------------------------------------------------------ОБЩАЯ РАБОТА ВАРИАНТ-1

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("Элементы в массиве [");
//     for (int i = 0; i < arr.Length; i++)
//     {

//         if (i < arr.Length - 1)
//             Console.Write($"{arr[i]}, ");
//         else
//             Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }

// int[] GetSumPositiveNegativeElem(int[] arr)
// {
//     int sumPositive = 0;
//     int sumNegative = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0)
//             sumNegative = sumNegative + arr[i];
//         else
//             sumPositive = sumPositive + arr[i];
//     }

//     return new int[] { sumNegative, sumPositive };
// }

// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
// int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
// Console.WriteLine($"сумма положительных чисел = {sumPositiveNegativeElem[1]}");
// Console.WriteLine($"сумма отрицательных чисел = {sumPositiveNegativeElem[0]}");

//--------------------------------------------------------------------------------------------------------------------------------------------ОБЩАЯ РАБОТА ВАРИАНТ-2

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("Элементы в массиве [");
//     for (int i = 0; i < arr.Length; i++)
//     {

//         if (i < arr.Length - 1)
//             Console.Write($"{arr[i]}, ");
//         else
//             Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }

// int GetSumPositiveElem(int[] arr)
// {
//     int sum = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sum = sum + arr[i];
//     }

//     return sum;
// }

// int GetSumNegativeElem(int[] arr)
// {
//     int sum = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0) sum = sum + arr[i];
//     }

//     return sum;
// }

// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
// int sumPositiveElem = GetSumPositiveElem(array);
// int sumNegativeElem = GetSumNegativeElem(array);
// Console.WriteLine($"сумма положительных чисел = {sumPositiveElem}");
// Console.WriteLine($"сумма отрицательных чисел = {sumNegativeElem}");
