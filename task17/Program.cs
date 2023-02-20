// 17. Напишите программу, которая принимает на вход
// координаты точки (x и y), причём x ≠ 0 и y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта точка.


Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xc = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yc = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xc, yc);
string result = quarter > 0
                ? $"Указанные координаты соответствуют четверти -> {quarter}"
                : $"Введены некорректные данные!";
Console.WriteLine(result);

// if (result > 0)
//     Console.WriteLine($"Quarter -> {quarter}");
// else
//     Console.WriteLine($"Введены некорректные данные!");

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;

}