// 57. Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается элемент
// входных данных.
// {1, 9, 9, 0, 2, 8, 0, 9}
// 0 = 2
// 1 = 1
// 2 = 1 
// 8 = 1
// 9 = 3

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

int[] MatrixToArray(int[,] matrix)
{
    int index = 0;
    int[] arr = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[index] = matrix[i, j];
            index++;
        }
    }
    return arr;
}

void SumElemArray(int[] arr)
{
    int count = 1;
    int curentNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == curentNumber)
            count++;
        else
        {
            Console.WriteLine($"Число {curentNumber} встречается {count} раз.");
            curentNumber = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {curentNumber} встречается {count} раз.");
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
int[] array = MatrixToArray(matrixRnd);
PrintMatrix(matrixRnd);
Console.WriteLine();
PrintArray(array);
Array.Sort(array);
PrintArray(array);
SumElemArray(array);
