// 10. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//-------------------------------------------------------------------------------------------------------------------------------------------------------МОЁ РЕШЕНИЕ

Console.WriteLine("Введите число:");

int number = Convert.ToInt32(Console.ReadLine());

int Mult(int num)
{
    int firstNum = num / 10;
    int secondNum = firstNum % 10;
    return secondNum;
}

int result = Mult(number);
Console.WriteLine($"{number} -> {result}");

//-----------------------------------------------------------------------------------------------------------------------------------------------------ПРЕПОДОВАТЕЛЯ

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int number = Prompt("Введите трёхзначное число > ");
// if (number < 100 || number >= 1000)
// {
//     Console.WriteLine("Вы ввели не трёхзначное число, пожалуйста повторите ввод");
//     return;
// }

// Console.WriteLine($"Введённое число `{number}`");
// int secondRank = number / 10 % 10;
// Console.WriteLine($"Вторая цифра `{secondRank}`");