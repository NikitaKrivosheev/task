// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число:");

int n = Convert.ToInt32(Console.ReadLine());
int i = 0;

Console.Write($"{n} -> ");

while(i < n-1)
{
    i += 2;
    Console.Write($"{i}, ");
}

if(i == 0) Console.Write("Ошибка");