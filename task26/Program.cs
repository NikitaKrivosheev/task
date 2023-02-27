// 26. Напишите программу, уоторая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int number = Prompt("Введите число: ");

int QuantityNumbers(int num)
{
    int quantity = 0;
    if (num == 0)
        return 1;
    else
        while (num != 0)
        {
            quantity++;
            num /= 10;
        }
    return quantity;
}
int res = QuantityNumbers(number);

Console.WriteLine($"Количество цифр в числе {number} -> {res}");