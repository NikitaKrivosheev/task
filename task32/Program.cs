// 32. Напишите программу замена элементов массива:
// положительные элементы заменить на соответствующие 
// отрицательные, и наоборот
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


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
    Console.WriteLine("]");
}

void SignReplacementInArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * (-1);
    }
}

int[] array = ArrayRnd(12, -9, 9);
PrintArray(array);
SignReplacementInArray(array);
Console.WriteLine($"Замена знаков: ");
PrintArray(array);