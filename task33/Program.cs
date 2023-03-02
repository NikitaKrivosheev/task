// 33. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. 
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите число, которое хотите проверить: ");
int digit = Convert.ToInt32(Console.ReadLine());

int[] ArrayRndInt(int num, int min, int max)
{
    int[] arr = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, int num)
{
    Console.Write($"{num} - в массиве [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.Write("] -> ");
}

bool FindElement(int[] arr, int find)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == find)
        {
            return true;
        }
    }
    return false;
}

int[] array = ArrayRndInt(12, 1, 9);
PrintArray(array, digit);
if (FindElement(array, digit))
    Console.Write($"присутствует - {digit}");
else
    Console.Write($"отсутствует - {digit}");