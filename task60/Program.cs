// 60. Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int[,,] CreateMatrixInt(int rows, int columns, int depth, int count)
{
    int[,,] matrix = new int[rows, columns, depth];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, j, k] += count;
                count += 1;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            Console.Write("|");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i, j, k],5} ({i},{j},{k})");
            }
            Console.WriteLine("|");
        }
    }
}

bool CheckMinMax(int min, int max)
{
    if (min >= 10
        && max <= 99
        && max > min
        && min < max)
        return true;
    else
        return false;
}

int from = 50;
int before = 99;
int[,,] matrixInt = CreateMatrixInt(3, 3, 3, from);
if (CheckMinMax(from, before))
    PrintMatrix(matrixInt);
else
    Console.WriteLine("Ошибка ввода данных.");


