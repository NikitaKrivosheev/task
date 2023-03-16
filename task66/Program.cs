// 66. Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15. -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num1, int num2)
{
    if (num2 < num1) return 0;
    else return num2 + SumNumbers(num1, num2 - 1);
}

int sumNumbers = SumNumbers(numberM, numberN);
if (numberM < 0 && numberN < 0)
    Console.WriteLine($"Ошибка ввода данных.");
else
    Console.WriteLine($"Сумма от {numberM} до {numberN} => {sumNumbers}");
