// 68. Напишите программу вычисления функций Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int AckermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AckermanFunc(m - 1, 1);
    return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
}

int result = AckermanFunc(numberM, numberN);
if (numberM < 0 && numberN < 0)
    Console.WriteLine($"Ошибка ввода данных.");
else
    Console.WriteLine($"A({numberM},{numberN}) => {result}");

