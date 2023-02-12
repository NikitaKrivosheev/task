// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.WriteLine("Введите числа:");

int num = Convert.ToInt32(Console.ReadLine());

if(num >= 100 && num <= 999)
{
    int lastNum = num % 10;
    Console.Write($"Последняя цифра числа -> {lastNum}");
}
else 
{
    Console.Write("Ошибка ввода данных");
}
