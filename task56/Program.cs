// 56. Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] SumMatrix(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arr[i] = sum;
    }
    return arr;
}

int ArrayMinRow(int[] arr)
{
    int row = arr[0];
    int count = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < row)
        {
            row = arr[i];
            count = i;        //or  count = i + 1;
        }
    }
    return count;
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

void PrintArray(int[] arr)
{
    Console.Write("|");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],3}");
    }
    Console.WriteLine("|");
}

int[,] matrixRnd = CreateMatrixRndInt(3, 3, 1, 10);
int[] sumMatrix = SumMatrix(matrixRnd);
int arrayMinRow = ArrayMinRow(sumMatrix);
PrintMatrix(matrixRnd);
Console.WriteLine();
PrintArray(sumMatrix);
Console.WriteLine($"Строка по индексу ({arrayMinRow}) с наименьшей суммой элементов.");
// Console.WriteLine($"Строка ({arrayMinRow + 1}) с наименьшей суммой элементов.");