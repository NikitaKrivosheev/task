// 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число:");

int number = Convert.ToInt32(Console.ReadLine());

void PrintDigit(int num)
{
    int index = num;

    if (num > 100)
    {
        while (index > 999)
        {
            index = index / 10;
        }
        int result = index % 10;
        Console.WriteLine($"{num} -> {result}");
    }
    else
    {
        Console.WriteLine($"{num} -> третьей цифры нет");
    }
}

PrintDigit(number);