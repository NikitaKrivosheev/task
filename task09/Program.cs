// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

//--------------------------------------------------------------------------------------------------------------------------------------------------------БЕЗ МЕТОДА

// int number = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// int firstDigit = number / 10;   // int - целочисленное деление ( отсеивается дробная часть )
// int lastDigit = number % 10;

// if (firstDigit > lastDigit)
// {
//     Console.WriteLine($"Наибольшая цифра числа -> {number} => {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра числа -> {number} => {lastDigit}");
// }

//-----------------------------------------------------------------------------------------------------------------------------------------------------------МЕТОД-1

// int number = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// int MaxDigit(int num)
// {
//     int a = num / 10;
//     int b = num % 10;
//     int max = a;
//     if (b > max) max = b;
//     return max;
// }

// int maximum = MaxDigit(number);
// Console.WriteLine($"Наибольшая цифра числа -> {number} => {maximum}");

//-----------------------------------------------------------------------------------------------------------------------------------------------------------МЕТОД-2

// int number = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// int MaxDigit(int num)
// {
//     int firstDigit = num / 10;
//     int secondDigit = num % 10;
//     if (firstDigit > secondDigit) return firstDigit;
//     else return secondDigit;
// }

// int maximum = MaxDigit(number);
// Console.WriteLine($"Наибольшая цифра числа -> {number} => {maximum}");

//-------------------------------------------------------------------------------------------------------------------------------------ТЕРНАРНОЕ ВЫРАЖЕНИЕ - МЕТОД-3

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;

    // int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    // return result;

    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maximum = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {number} => {maximum}");

//------------------------------------------------------------------------------------------------------------------------------------ПОВТОРНОЕ ИСПОЛЬЗОВАНИЕ МЕТОДА

// int maximum2 = MaxDigit(43);
// Console.WriteLine($"Наибольшая цифра числа -> {43} => {maximum2}");

// int maximum3 = MaxDigit(65);
// Console.WriteLine($"Наибольшая цифра числа -> {65} => {maximum3}");