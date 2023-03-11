// 50. Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возращает значиние этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

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

bool PositionElement(int[,] matrix, int pos, int pos2)
{
    return pos < matrix.GetLength(0)
        && pos2 < matrix.GetLength(1)
        && pos > 0
        && pos2 > 0;
}

int[,] matrixRnd = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrixRnd);

Console.WriteLine($"Введите позиции элемента в двумерном массиве: ");
int positionRow = Convert.ToInt32(Console.ReadLine());
int positionColumn = Convert.ToInt32(Console.ReadLine());

if (PositionElement(matrixRnd, positionRow, positionColumn))
    Console.WriteLine($"Элемент в двухмерном массиве: {matrixRnd[positionRow, positionColumn]}");
else
    Console.WriteLine($"{positionRow},{positionColumn} такого элемента в массиве нет.");