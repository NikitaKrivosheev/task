// 18. Напишите программу, которая по 
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (X и Y).

//--------------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА

Console.WriteLine("Введите номер четверти:");
Console.Write("Четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());

Coord(quarter);

void Coord(int num)
{
    int firstQuarter = 1;
    int secondQuarter = 2;
    int thirdQuarter = 3;
    int fourthQuarter = 4;
    int x = new Random().Next(1, 10);
    int y = new Random().Next(1, 10);

    if (num == firstQuarter)
        Console.WriteLine($"( X > 0 && Y > 0 ) Например -> ( X: {x}, Y: {y} )");
    else if (num == secondQuarter)
        Console.WriteLine($"( X < 0 && Y > 0 ) Например -> ( X: {-x}, Y: {y} )");
    else if (num == thirdQuarter)
        Console.WriteLine($"( X < 0 && Y < 0 ) Например -> ( X: {-x}, Y: {-y} )");
    else if (num == fourthQuarter)
        Console.WriteLine($"( X > 0 && Y < 0 ) Например -> ( X: {x}, Y: {-y} )");
    else
        Console.WriteLine("Введен неверный номер четверти.");
}

//------------------------------------------------------------------------------------------------------------------------------------------------------ОБЩАЯ РАБОТА

// string Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     return value;
// }

// string Range(string mes)
// {
//     if (mes == "1") return "x > 0 && y > 0";
//     if (mes == "2") return "x < 0 && y > 0";
//     if (mes == "3") return "x < 0 && y < 0";
//     if (mes == "4") return "x > 0 && y < 0";
//     return "0";
// }

// string val = Prompt("Введите номер четверти: ");
// string range = Range(val);
// string result = range == "0"
//         ? $"Некорректный ввод данных"
//         : $"диапазон возможных координат точек в этой четверти {range}";
// Console.WriteLine(result);