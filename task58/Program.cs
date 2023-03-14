// 58. Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

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

int[,] ProductOfTwoMatrices(int[,] matrixA, int[,] matrixB)
{
    int[,] newMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                newMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return newMatrix;
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

int[,] matrixRndA = CreateMatrixRndInt(2, 3, 1, 10);
int[,] matrixRndB = CreateMatrixRndInt(3, 2, 1, 10);
int[,] productOfTwoMatrices = ProductOfTwoMatrices(matrixRndA, matrixRndB);
PrintMatrix(matrixRndA);
Console.WriteLine();
PrintMatrix(matrixRndB);
Console.WriteLine();
PrintMatrix(productOfTwoMatrices);

