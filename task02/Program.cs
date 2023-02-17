// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3


Console.WriteLine("Введите числа:");

int firstNum = Convert.ToInt32(Console.ReadLine());
int lastNum = Convert.ToInt32(Console.ReadLine());

Console.Write($"a = {firstNum}; b = {lastNum} -> ");

if (firstNum > lastNum)
{
    Console.WriteLine("max = " + firstNum);
}
else
{
    Console.WriteLine("max = " + lastNum);
}