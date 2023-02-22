// 22. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

//-------------------------------------------------------------------------------------------------------------------------------------------------------------WHILE

// int Prompt(string message)
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// void SquareNumber(int n)
// {
//     int i = 1;

//     if (n > 0)
//     {
//         while (i <= n)
//         {
//             int square = i * i;
//             Console.WriteLine($"Квадрат числа: {i,5} = {square,5}");
//             i++;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Введено не натуральное число.");
//     }
// }

// int number = Prompt("Введите число: ");
// SquareNumber(number);

//---------------------------------------------------------------------------------------------------------------------------------------------------------------FOR

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void SquareNumber(int n)
{
    if (n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            int square = i * i;
            Console.WriteLine($"Квадрат числа: {i,5} = {square,5}");
        }
    }
    else
    {
        Console.WriteLine("Введено не натуральное число.");
    }
}

int number = Prompt("Введите число: ");
SquareNumber(number);