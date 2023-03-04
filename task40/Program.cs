// 40. Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами
// такой длины.

Console.Write("Введите первое число треугольника: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool TriangleInequality(int ab, int ac, int cb)
{
    if (ab + ac > cb && ac + cb > ab && ab + cb > ac)
        return true;
    else
        return false;
}

bool triangle = TriangleInequality(number, number2, number3);
Console.WriteLine(triangle ? "Да" : "Нет");

