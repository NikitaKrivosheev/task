// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> Да
// -4, 16 -> Да
// 25, 5 -> Да
// 8, 9 -> Нет 

//--------------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА

// Console.WriteLine("Введите числа:");

// int firstNum = Convert.ToInt32(Console.ReadLine());
// int secondNum = Convert.ToInt32(Console.ReadLine());

// bool Mult(int firstDigit, int secondDigit)
// {
//     if (firstDigit > secondDigit)
//     {
//         int res = secondDigit * secondDigit;
//         return firstDigit == res;
//     }
//     else
//     {
//         int res = firstDigit * firstDigit;
//         return res == secondDigit;
//     }
// }

// bool result = Mult(firstNum, secondNum);

// if (result)
//     Console.WriteLine($"{firstNum}, {secondNum} -> Да");
// else
//     Console.WriteLine($"{firstNum}, {secondNum} -> Нет");

//-------------------------------------------------------------------------------------------------------------------------------------------------------------ОБЩАЯ

Console.WriteLine("Введите числа:");

int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());

bool Mult(int firstDigit, int secondDigit)
{
    return firstDigit == secondDigit * secondDigit || secondDigit == firstDigit * firstDigit;
}

if (Mult(firstNum, secondNum))
    Console.WriteLine($"{firstNum}, {secondNum} -> Да");
else
    Console.WriteLine($"{firstNum}, {secondNum} -> Нет");