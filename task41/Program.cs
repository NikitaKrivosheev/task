// 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

//--------------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА

Console.Write("Введите количество элементов массива: ");
int digit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива: ");

int[] CreateArrayInt(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountNumArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count += 1;
    }
    return count;
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
    Console.Write("] -> ");
}

int[] createArrayInt = CreateArrayInt(digit);
PrintArray(createArrayInt);
int countNumArray = CountNumArray(createArrayInt);
Console.WriteLine($"Введенное количество чисел больше 0 = {countNumArray}");

//------------------------------------------------------------------------------------------------------------------------------------------------------ОБЩАЯ РАБОТА

// double Prompt(string message)
// {
//     Console.Write(message);
//     double result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[] InputArray(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Prompt($"Введите {i + 1}-й элемент");
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"a[{i}] = {array[i]}");
//     }
// }

// int CountPositionNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int lenght = Prompt("Введите количество элементов >");
// int[] array;
// array = InputArray(lenght);
// PrintArray(array);
// Console.WriteLine($"Количество чисел больше 0 - {CountPositionNumbers(array)}");