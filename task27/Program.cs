// 27. Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//---------------------------------------------------------------------------------------------------------------------------------------------------------ВАРИАНТ-1

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void SumNumbers(int num)
{
    int sum = 0;
    int result = num;
    for (int i = 1; i <= num; i *= 10)
    {
        sum = sum + result % 10;
        result /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе -> {num} = {sum}");
}
SumNumbers(number);

//-----------------------------------------------------------------------------------------------------------------------------------------------ВАРИАНТ-2 С МИНУСОМ

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// void SumNumbers(int num)
// {
//     int sum = 0;
//     int count = num * (-1);
//     int result = num;
//     if (num > 0)
//     {
//         for (int i = 1; i <= num; i *= 10)
//         {
//             sum = sum + result % 10;
//             result /= 10;
//         }
//         Console.WriteLine($"Сумма цифр в числе -> {num} = {sum}");
//     }
//     else
//     {
//         for (int i = 1; i <= count; i *= 10)
//         {
//             sum = sum + result % 10;
//             result /= 10;
//         }
//         Console.WriteLine($"Сумма цифр в числе -> {num} = {sum}");
//     }
// }
// SumNumbers(number);