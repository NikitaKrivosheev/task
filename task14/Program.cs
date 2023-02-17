// 14. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

//--------------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА

// Console.WriteLine("Введите число:");

// int digit = Convert.ToInt32(Console.ReadLine());

// bool Mult(int num)
// {
//     int firstNum = num % 7;
//     int secondNum = num % 23;
//     return firstNum == secondNum;
// }

// bool result = Mult(digit);                      
//                                                 
// if (result)                                   
//     Console.WriteLine($"{digit} -> Да");
// else
//     Console.WriteLine($"{digit} -> Нет");

//-------------------------------------------------------------------------------------------------------------------------------------------------------------ОБЩАЯ

Console.WriteLine("Введите число:");
int digit = Convert.ToInt32(Console.ReadLine());

bool Mult(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

if (Mult(digit))
    Console.WriteLine($"{digit} -> Да");
else
    Console.WriteLine($"{digit} -> Нет");