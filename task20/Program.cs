// 20. Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B(2,1) -> 5,09
// A (7,-5); B(1,-1) -> 7,21

// Math.Sqrt(5) - извлечение корня
// Math.Pow(2, 10) - возведение в степень 
// double d = 5.09998774;
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero); - округление     
// MidpointRounding.ToZero - стратегия округления (В поиске найти - C# форматирование выводов)
// Console.WriteLine(dRound)


Console.WriteLine("Введите координаты двух точек:");
Console.Write("Первая точка по X1: ");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка по Y1: ");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка по X2: ");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка по Y2: ");
int numY2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(numX1, numY1, numX2, numY2);
Console.Write(Math.Round(result, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2)
{
    double sumSquare = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
    double root = Math.Sqrt(sumSquare);
    return root;
}