// 62. Заполните спиральный массив 4 на 4.
//  1  2  3  4 
// 12 13 13  5
// 11 16 15  6
// 10  9  8  7

int[,] CreateSpiralMatrixInt(int rows, int columns, int elem)
{
    int[,] matrix = new int[rows, columns];
    int i = 0;
    int j = 0;

    while (elem <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = elem;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1) j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1) i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1) j--;
        else i--;
        elem++;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ({i},{j})");
        }
        Console.WriteLine("|");
    }
}

int[,] spiralMatrix = CreateSpiralMatrixInt(4, 4, 1);
PrintMatrix(spiralMatrix);
