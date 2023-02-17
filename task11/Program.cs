// 11. Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

//--------------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int Function(int digit)
{
    int firstNum = (digit / 100) * 10;
    int secondNum = digit % 10;
    return firstNum + secondNum;
}

int sum = Function(number);
Console.WriteLine($"{number} -> {sum}");

//------------------------------------------------------------------------------------------------------------------------------------------------------ОБЩАЯ РАБОТА

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// int Function(int digit)
// {
//     int firstNum = digit / 100;
//     int secondNum = digit % 10;
//     int result = firstNum * 10 + secondNum;
//     return result;
// }

// int sum = Function(number);
// Console.WriteLine($"{number} -> {sum}");