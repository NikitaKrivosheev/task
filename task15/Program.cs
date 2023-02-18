// 15. Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите число:");

int number = Convert.ToInt32(Console.ReadLine());

int noDay = 1;
int noDay2 = 7;

bool DayOfTheWeek(int num)
{
    int saturday = 6;
    int sunday = 7;
    return num == saturday || num == sunday;
}

if (DayOfTheWeek(number))
    Console.WriteLine($"{number} -> Да");
else if (number > noDay2 || number < noDay)
    Console.WriteLine($"{number} -> Такого дня недели нет");
else
    Console.WriteLine($"{number} -> Нет");