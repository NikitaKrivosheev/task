// 24. Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36


int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int number = Prompt("Введите число: ");

int SumNumber(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
int res = SumNumber(number);

if (number > 0)
    Console.WriteLine($"Сумма чисел от 1 до {number} = {res}");
else
    Console.WriteLine("Введено не натуральное число.");