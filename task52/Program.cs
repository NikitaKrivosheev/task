// 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 
// Среднее арифметическое кафдого столбца: 4,6; 5,6; 3,6; 3.

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

double[] AverageMatrix(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        arr[j] = sum / matrix.GetLength(0);
    }
    return arr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }
}

void PrintAverageMatrix(double[] arr)
{
    Console.Write("|");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{Math.Round(arr[i], 1),5}");
    }
    Console.WriteLine("|");
}

int[,] matrixRnd = CreateMatrixRndInt(3, 4, 1, 10);
double[] averageMatrix = AverageMatrix(matrixRnd);
PrintMatrix(matrixRnd);
Console.WriteLine("Среднее фрифметическое каждого столбца:");
PrintAverageMatrix(averageMatrix);