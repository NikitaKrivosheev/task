// 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void СubeNumber(int n)
{
    int i = 1;

    if (n > 0)
    {
        while (i <= n)
        {
            int cube = i * i * i;
            Console.WriteLine($"Куб числа: {i,5} = {cube,5}");
            i++;
        }
    }
    else
    {
        Console.WriteLine("Введено не натуральное число.");
    }
}

int number = Prompt("Введите число: ");
СubeNumber(number);