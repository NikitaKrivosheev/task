// 12. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли первое число кратным второму. Если число 1 не кратно числу 2,
// то программа выводит остаток от деления.
// 34,5 -> не кратно, остаток 4
// 16,4 -> кратно

//------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА МЕТОД-1

// Console.WriteLine("Введите числа:");

// int number = Convert.ToInt32(Console.ReadLine());
// int num = Convert.ToInt32(Console.ReadLine());

// int Function(int firstDigit, int secondDigit)
// {
//     int result = firstDigit > secondDigit ? firstDigit % secondDigit : secondDigit % firstDigit;
//     return result;
// }

// int rem = Function(number, num);

// if (rem == 0)
//     Console.WriteLine($"{number}, {num} -> кратно");
// else
//     Console.WriteLine($"{number}, {num} -> не кратно, остаток {rem}");

//------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА МЕТОД-2

// Console.WriteLine("Введите числа:");

// int number = Convert.ToInt32(Console.ReadLine());
// int num = Convert.ToInt32(Console.ReadLine());

// int Function(int firstDigit, int secondDigit)
// {
//     int result = 0;
//     if (firstDigit > secondDigit)
//         result = firstDigit % secondDigit;
//     else
//         result = secondDigit % firstDigit;
//     return result;
// }

// int rem = Function(number, num);

// if (rem == 0)
//     Console.WriteLine($"{number}, {num} -> кратно");
// else
//     Console.WriteLine($"{number}, {num} -> не кратно, остаток {rem}");

//------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА МЕТОД-3

// Console.WriteLine("Введите числа:");

// int number = Convert.ToInt32(Console.ReadLine());
// int num = Convert.ToInt32(Console.ReadLine());

// int Function(int firstDigit, int secondDigit)
// {
//     if (firstDigit > secondDigit)
//         return firstDigit % secondDigit;
//     else
//         return secondDigit % firstDigit;
// }

// int rem = Function(number, num);

// if (rem == 0)
//     Console.WriteLine($"{number}, {num} -> кратно");
// else
//     Console.WriteLine($"{number}, {num} -> не кратно, остаток {rem}");

//------------------------------------------------------------------------------------------------------------------------------------САМОСТОЯТЕЛЬНАЯ РАБОТА МЕТОД-4

Console.WriteLine("Введите числа:");

int number = Convert.ToInt32(Console.ReadLine());
int num = Convert.ToInt32(Console.ReadLine());

int Function(int firstDigit, int secondDigit)
{
    if (firstDigit > secondDigit)
        return firstDigit % secondDigit;
    else
        return secondDigit % firstDigit;
}

int rem = Function(number, num);

void Operation(int variable, int input, int input2)
{
    if (variable == 0)
        Console.WriteLine($"{input}, {input2} -> кратно");
    else
        Console.WriteLine($"{input}, {input2} -> не кратно, остаток {variable}");
}

Operation(rem, number, num);
