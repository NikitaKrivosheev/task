// 25. Напишите цикл, который принимает на вход 
// два числа (А и В) и возводит число А в натуральную 
// степень В.
// 3,5 -> 243
// 2,4 -> 16

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void Degree(int num, int num2)
{
    int result = num;
    if (num != 0 && num2 != 0)
    {
        for (int i = 1; i < num2; i++)
        {
            result = result * num;
        }
        Console.WriteLine($"{num} в степени {num2} = {result}");
    }
    else
    {
        Console.WriteLine("Введено не натурально число.");
    }
}
Degree(number, number2);
