// 28. Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int number = Prompt("Введите число: ");

int FactorialNumber(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    return factorial;
}
int res = FactorialNumber(number);

if (number != 0)
    Console.WriteLine($"Произведение чисел от 1 до {number} = {res}");
else
    Console.WriteLine("Введено не натуральное число.");