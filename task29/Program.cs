// 29. Напишите программу, которая задаёт
// массив из 8 элементов, заполненный 
// псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//---------------------------------------------------------------------------------------------------------------------------------------------------------ВАРИАНТ-1

// Console.Write("Введите количество элементов в массиве: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] RandomArray(int num)
// {
//     Random rand = new Random();
//     int[] arr = new int[num];
//     int count = arr.Length;
//     for (int i = 0; i < count; i++)
//     {
//         arr[i] = rand.Next(1, 33);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     int n = arr.Length;
//     Console.Write($"[");
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write($"{arr[i]}");
//         if (i < n - 1) Console.Write($", ");
//     }
//     Console.Write($"]");
// }

// int[] array = RandomArray(number);
// Console.Write($"Массив из {number} элементов: ");
// PrintArray(array);

//---------------------------------------------------------------------------------------------------------------------------------------------------------ВАРИАНТ-2

int[] arr = new int[8];

void RandomNumbers(int[] num)
{
    Random rand = new Random();
    int n = num.Length;
    for (int index = 0; index < n; index++)
    {
        num[index] = rand.Next(1, 33);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write($"[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
        if (i < count - 1) Console.Write($", ");
    }
    Console.Write($"]");
}

RandomNumbers(arr);
PrintArray(arr);