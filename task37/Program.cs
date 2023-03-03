// 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и тд. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

//--------------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА

int[] ArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("Элементы в массиве [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.Write("] ");
}

int[] ProductOfNumbers(int[] arr)
{
    int k = 0;
    int n = arr.Length;
    if (n % 2 == 0)
    {
        k = n / 2;
        int[] newArr = new int[k];

        for (int i = 0; i < k; i++)
        {
            newArr[i] = arr[i] * arr[n - i - 1];
        }
        return newArr;
    }
    else
    {
        k = (n + 1) / 2;
        int[] newArr = new int[k];

        for (int i = 0; i < k; i++)
        {
            newArr[i] = arr[i] * arr[n - i - 1];
            if (i == k - 1) newArr[i] = arr[i];
        }
        return newArr;
    }
}

int[] array = ArrayRnd(10, 1, 10);
PrintArray(array);
int[] productOfNumbers = ProductOfNumbers(array);
PrintArray(productOfNumbers);

//--------------------------------------------------------------------------------------------------------------------------------------------ОБЩАЯ РАБОТА с ошибкой

// int[] ArrayRnd(int size, int min, int max)
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
//     Console.Write("] ");
// }

// int[] ProductOfNumbers(int[] arr)
// {
//     int size = arr.Length / 2;
//     if (arr.Length % 2 != 0) size += 1;

//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = arr[i] * arr[arr.Length - i - 1];
//     }
//     if (newArray.Length % 2 != 0)
//         newArray[newArray.Length - 1] = arr[size - 1];
//     return newArray;
// }

// int[] array = ArrayRnd(6, 0, 10);
// PrintArray(array);
// int[] productOfNumbers = ProductOfNumbers(array);
// PrintArray(productOfNumbers);