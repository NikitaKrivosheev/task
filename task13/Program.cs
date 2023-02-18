// 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//-------------------------------------------------------------------------------------------------------------------------------------------------------МОЁ РЕШЕНИЕ

Console.WriteLine("Введите число:");

int number = Convert.ToInt32(Console.ReadLine());

void PrintDigit(int num)
{
    int index = num;

    if (num > 100)
    {
        while (index > 999)
        {
            index = index / 10;
        }
        int result = index % 10;
        Console.WriteLine($"{num} -> {result}");
    }
    else
    {
        Console.WriteLine($"{num} -> третьей цифры нет");
    }
}

PrintDigit(number);

//-----------------------------------------------------------------------------------------------------------------------------------------------------ПРЕПОДОВАТЕЛЯ

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int GetThirdRank(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }

// bool ValidateNumber(int number)
// {
//     if (number < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//         return false;
//     }
//     return true;
// }

// int number = Prompt("Введите число > ");
// if (ValidateNumber(number))
// {
//     Console.WriteLine(GetThirdRank(number));
// }