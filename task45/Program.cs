// 45. Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.

int[] ArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int[] CopyArray(int[] arr)
{
    int[] copyArr = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        copyArr[i] = arr[i];
    }
    return copyArr;
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
    Console.WriteLine("] ");
}

int[] array = ArrayRndInt(12, 1, 9);
PrintArray(array);
int[] copyArray = CopyArray(array);
copyArray[0] = 99;
PrintArray(copyArray);
