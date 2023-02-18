// 10. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число:");

int number = Convert.ToInt32(Console.ReadLine());

int Mult(int num)
{
    int firstNum = num / 10;
    int secondNum = firstNum % 10;
    return secondNum;
}

int result = Mult(number);
Console.WriteLine($"{number} -> {result}");