// 49. Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их
// квадраты. 
// Массив 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив
// 1 4 49 2 
// 5 9 2 3 
// 64 4 4 4 

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

// int[,] CreateMatrixSquareInt(int[,] matrix)
// {
//     int[,] matrix2 = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix2.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//                 matrix2[i, j] = matrix[i, j] * matrix[i, j];
//             else
//                 matrix2[i, j] = matrix[i, j];
//         }
//     }
//     return matrix2;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],4}");
//         }
//         Console.WriteLine("|");
//     }
// }

// int[,] matrixRnd = CreateMatrixRndInt(3, 4, 1, 10);
// int[,] squareMatrix = CreateMatrixSquareInt(matrixRnd);
// PrintMatrix(matrixRnd);
// Console.WriteLine();
// PrintMatrix(squareMatrix);

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

// void ReplaceEvenElems(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//                 matrix[i, j] *= matrix[i, j];
//         }
//         Console.WriteLine("|");
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.WriteLine("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],3}");
//         }
//         Console.WriteLine("|");
//     }
// }

// int[,] matrixRnd = CreateMatrixRndInt(3, 4, 1, 10);
// PrintMatrix(matrixRnd);
// Console.WriteLine();
// ReplaceEvenElems(matrixRnd);
// PrintMatrix(matrixRnd);

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

void ReplaceEvenElems(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

int[,] matrixRnd = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrixRnd);
Console.WriteLine();
ReplaceEvenElems(matrixRnd);
PrintMatrix(matrixRnd);
