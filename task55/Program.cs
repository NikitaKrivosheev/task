// 55. Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это 
// невозможно, программа должа вывести сообщение для пользователя.

//--------------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА

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

int[,] ReversalRowsColumnMatrix(int[,] matrix)
{
    int[,] matrix2 = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix2[j, i] = matrix[i, j];
        }
    }
    return matrix2;
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
int[,] reversal = ReversalRowsColumnMatrix(matrixRnd);
int row = matrixRnd.GetLength(0);
int column = matrixRnd.GetLength(1);
PrintMatrix(matrixRnd);
Console.WriteLine();
if (row != column)
    Console.WriteLine("Задан разный диапазон данных для двумерного массива");
else
    PrintMatrix(reversal);

//------------------------------------------------------------------------------------------------------------------------------------------------------ОБЩАЯ РАБОТА

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void ReversalRowsColumnMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0) - 1; i++)
//     {
//         for (int j = i + 1; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],3}");
//         }
//         Console.WriteLine("|");
//     }
// }

// int[,] matrixRnd = CreateMatrixRndInt(3, 4, 1, 10);
// int row = matrixRnd.GetLength(0);
// int column = matrixRnd.GetLength(1);
// ReversalRowsColumnMatrix(matrixRnd);
// PrintMatrix(matrixRnd);
// Console.WriteLine();
// if (row != column) Console.WriteLine("Задан разный диапазон данных для двумерного массива");
// else ReversalRowsColumnMatrix(matrixRnd);
// PrintMatrix(matrixRnd);
