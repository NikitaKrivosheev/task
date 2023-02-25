// 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 - нет
// 23432 - да 
// 12821 - да

//---------------------------------------------------------------------------------------------------------------------------------------------------------ВАРИАНТ-1

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int number = Prompt("Ведите число: ");

int NumberPalindrome(int num)
{
    int i = 0;
    int firstNum = num;
    while (i < num)
    {
        i = i + firstNum % 10;
        firstNum = firstNum / 10;
        i = i * 10;
    }
    i = i / 10;
    return i;
}
int res = NumberPalindrome(number);

if (number == res)
    Console.WriteLine($"{number} -> Да");
else
    Console.WriteLine($"{number} -> Нет");

//---------------------------------------------------------------------------------------------------------------------------------------------------------ВАРИАНТ-2

// int Prompt(string message)
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }
// int number = Prompt("Ведите число: ");

// int NumberPalindrome(int num)
// {
//     int i = 0;
//     int firstNum = num;
//     while (i < num)
//     {
//         i = i + firstNum % 10;
//         firstNum = firstNum / 10;
//         if (i != num) i = i * 10;
//     }
//     return i;
// }
// int res = NumberPalindrome(number);

// if (number == res)
//     Console.WriteLine($"{number} -> Да");
// else
//     Console.WriteLine($"{number} -> Нет");