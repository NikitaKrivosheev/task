﻿// 34. Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных 
// чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] ArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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

int ParityNumbers(int[] arr)
{
    int parity = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            parity += 1;
    }
    return parity;
}

int[] array = ArrayRnd(10, 100, 999);
PrintArray(array);
int parityNumbers = ParityNumbers(array);
Console.WriteLine($"В массиве {parityNumbers} чётных числа-ел");

