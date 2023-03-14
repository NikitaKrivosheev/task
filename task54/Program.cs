﻿// 54. Задайте двумерный массив. Напишите программу , которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int min = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, min] < matrix[i, k]) min = k;
            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, min];
            matrix[i, min] = temp;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

int[,] matrixRnd = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matrixRnd);
Console.WriteLine();
SortMatrix(matrixRnd);
PrintMatrix(matrixRnd);