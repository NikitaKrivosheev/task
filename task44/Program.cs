// 44. Не используя рекурсию, выведите первые N чисел
// фибоначи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int[] FibonacciNumbers(int num)
// {
//     int[] arr = new int[num];
//     arr[0] = 0;
//     arr[1] = 1;

//     for (int i = 2; i < arr.Length; i++)
//     {
//         arr[i] = arr[i - 1] + arr[i - 2];
//     }
//     return arr;
// }

int[] FibonacciNumbers(int num)
{
    int[] arr = new int[num];

    if (num > 0) arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
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

Console.Write("Введите число Фибоначи: ");
int digit = Convert.ToInt32(Console.ReadLine());
int[] fibonacciNumbers = FibonacciNumbers(digit);

if (digit > 1)
    PrintArray(fibonacciNumbers);
else
    Console.WriteLine("Такого числа нет.");