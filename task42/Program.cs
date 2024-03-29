﻿// 42. Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int BinaryNumber(int num)
{
    int count = 1;
    int result = 0;
    while (num > 0)
    {
        result = result + num % 2 * count;
        num /= 2;
        count *= 10;
    }
    return result;
}
int binaryNumber = BinaryNumber(number);
Console.WriteLine($"{number} -> {binaryNumber}");