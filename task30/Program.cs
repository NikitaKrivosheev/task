// 30. Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

//--------------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА

// int[] arr = new int[8];

// void RandomNumbers(int[] num)
// {
//     int n = num.Length;
//     for (int index = 0; index < n; index++)
//     {
//         num[index] = new Random().Next(0, 2);
//     }
// }

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
// }

// RandomNumbers(arr);
// PrintArray(arr);

//------------------------------------------------------------------------------------------------------------------------------------------------------ОБЩАЯ РАБОТА

Console.Write("Введите количество элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArray(number, 0, 1);
Console.Write($"Массив из {number} элементов: ");
PrintArray(array);

int[] RandomArray(int num, int min, int max)
{
    Random rand = new Random();
    int[] arr = new int[num];
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int n = arr.Length;
    Console.Write($"[");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{array[i]}");
        if (i < n - 1) Console.Write($", ");
    }
    Console.Write($"]");
}