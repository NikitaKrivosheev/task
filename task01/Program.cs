﻿// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.WriteLine("Введите числа:");

int firstNum = Convert.ToInt32(Console.ReadLine());
int lastNum = Convert.ToInt32(Console.ReadLine());
int square = firstNum * firstNum;

if(square == lastNum)
{
Console.WriteLine($"a = {firstNum}, b = {lastNum} -> Да");
}
else
{
Console.WriteLine($"a = {firstNum}, b = {lastNum} -> Нет");
}