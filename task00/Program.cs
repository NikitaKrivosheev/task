﻿// 0. Демонстрация решения
// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49


Console.WriteLine("Введите число:");

int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;

Console.WriteLine("Квадрат числа " + num + " = " + square);      // or Console.WriteLine($"Квадрат числа  {num} = {square}");