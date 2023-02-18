// 15. Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//-------------------------------------------------------------------------------------------------------------------------------------------------------МОЁ РЕШЕНИЕ

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

//-----------------------------------------------------------------------------------------------------------------------------------------------------ПРЕПОДОВАТЕЛЯ

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// bool IsWeekend(int weekDay)
// {
//     if (weekDay > 5)
//     {
//         return true;
//     }
//     return false;
// }

// bool ValidateWeekday(int number)
// {
//     if (number > 0 && number <= 7)
//     {
//         return true;
//     }
//     Console.WriteLine("Это не день недели!");
//     return false;
// }

// int weekDay = Prompt("Введите день недели >");
// if (ValidateWeekday(weekDay))
// {
//     if (IsWeekend(weekDay))
//     {
//         Console.WriteLine("Наконец-то выходной");
//     }
//     else
//     {
//         Console.WriteLine("Придётся поработать");
//     }
// }