// 51. Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами)
// (0,0); (1,1) и т.д.
// Массив
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12

//--------------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА

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

// int SumMatrixInt(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//                 sum += matrix[i, j];
//         }
//     }
//     return sum;
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
// int sumMatrix = SumMatrixInt(matrixRnd);
// PrintMatrix(matrixRnd);
// Console.WriteLine($"Сумма элементов главной диагонали = {sumMatrix}");

//-------------------------------------------------------------------------------------------------------------------------------------------------------ОПТИМИЗАЦИЯ

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

int SumMatrixInt(int[,] matrix)
{
    int sum = 0;
    int size = matrix.GetLength(0);
    if (size > matrix.GetLength(1)) size = matrix.GetLength(1);

    for (int i = 0; i < size; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
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

int[,] matrixRnd = CreateMatrixRndInt(4, 10, 1, 10);
int sumMatrix = SumMatrixInt(matrixRnd);
PrintMatrix(matrixRnd);
Console.WriteLine($"Сумма элементов главной диагонали = {sumMatrix}");