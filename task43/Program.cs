// 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения 
// b1, k1, b2, и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//--------------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА

Console.Write("Введите данные для b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите данные для k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите данные для b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите данные для k2:");
int k2 = Convert.ToInt32(Console.ReadLine());

double LineIntersection(int numB1, int numK1, int numB2, int numK2)
{
    double x1 = numK1 - numK2;
    double x2 = numB2 - numB1;
    double res = x2 / x1;
    return Math.Round(res, 1);
}

double LineIntersection2(int numB1, int numK1, int numB2, int numK2)
{
    double x1 = numK1 - numK2;
    double x2 = numB2 - numB1;
    double res = x2 / x1;
    double result = numK2 * res + numB2;
    return Math.Round(result, 1);
}

double line = LineIntersection(b1, k1, b2, k2);
double line2 = LineIntersection2(b1, k1, b2, k2);
Console.WriteLine($"{Math.Round(line, 1)}, {Math.Round(line2, 1)}");

//------------------------------------------------------------------------------------------------------------------------------------------------------ОБЩАЯ РАБОТА

// int coefficient = 0;
// int constant = 1;
// int xCoord = 0;
// int yCoord = 1;
// int line1 = 1;
// int line2 = 2;

// double[] lineData = InputLineData(line1);
// double[] lineData2 = InputLineData(line2);

// if (ValidateLines(lineData1, lineData1))
// {
//     double[] coord = FindCoords(lineData1, lineData2);
//     Console.Write($"Точка пересечения управлений y = {lineData1[coefficient]} * x + {lineData1[constant]} и y = {lineData2[coefficient]} * x + {lineData1[constant]}");
//     Console.WriteLine($"имеет координаты ({coord[xCoord]}, {coord[yCoord]})");
// }

// double Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     double result = Convert.ToInt32(value);
//     return result;
// }

// double[] InputLineData(int numberOfLine)
// {
//     double[] lineData = new double[2];
//     lineData[coefficient] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
//     lineData[constant] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
//     return lineData;
// }

// double[] FindCoords(double[] lineData1, double[] lineData2)
// {
//     double[] coord = new double[2];
//     coord[xCoord] = (lineData1[constant] - lineData2[constant]) / (lineData2[coefficient] - lineData1[coefficient]);
//     coord[yCoord] = lineData1[constant] * coord[xCoord] + lineData[constant];
//     return coord;
// }

// bool ValidateLines(double[] lineData1, double[] lineData2)
// {
//     if (lineData1[coefficient] == lineData2[coefficient])
//     {
//         if (lineData1[constant] == lineData2[constant])
//         {
//             Console.WriteLine("Прямые совпадают");
//             return false;
//         }
//         else
//         {
//             Console.WriteLine("Прямые параллельные");
//             return false;
//         }
//     }
//     return true;
// }

//-----------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА доделать

// int[] CreateArraydouble(int num)
// {
//     int[] arr = new int[num];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }
// int[] createArraydouble = CreateArraydouble(digit);

// Console.Write("Введите количество элементов массива: ");
// int digit = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите элементы массива: ");

// double[] CreateArrayDouble(int num)
// {
//     double[] arr = new double[num];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = Convert.ToDouble(Console.ReadLine());
//     }
//     return arr;
// }
// double[] createArrayDouble = CreateArrayDouble(digit);

// void PrintArrayDouble(double[] arr)
// {
//     Console.Write("Элементы в массиве [");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1)
//             Console.Write($"{Math.Round(arr[i], 1)}, ");
//         else
//             Console.Write($"{Math.Round(arr[i], 1)}");
//     }
//     Console.Write("] -> ");
// }
// PrintArrayDouble(createArrayDouble);

// double[] LineIntersection(double[] num, double[] num2)
// {
//     double[] arr = new double[4];
//     arr[i] = numK1 - numK2;
//     double x2 = numB2 - numB1;
//     double res = x2 / x1;
//     return Math.Round(res, 1);
// }

// double line = LineIntersection(b1, k1, b2, k2);