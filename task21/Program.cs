// 21. Напишите программу, которая принимает на 
// вход координаты точек и находит расстояние между ними
// в 3D пространстве.
// A(3,6,8); B(2,1,-7), -> 15.84
// A(7,-5,0); B(1,-1,9) -> 11.53


Console.WriteLine("Введите координаты двух точек:");
Console.Write("Первая точка по X1: ");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка по Y1: ");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка по Z1: ");
int numZ1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка по X2: ");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка по Y2: ");
int numY2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка по Z2: ");
int numZ2 = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double sumSquare = (x2 - x1) * (x2 - x1)
    + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1);
    double root = Math.Sqrt(sumSquare);
    return root;
}

double result = Distance(numX1, numY1, numZ1, numX2, numY2, numZ2);
Console.Write(Math.Round(result, 2, MidpointRounding.ToZero));