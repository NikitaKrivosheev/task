// 69. Нампишите программу, которая на вход принимает два числа A и B, и 
// возводить число A в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3^5)
// A = 2; B = 3 -> 8

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int powNumbers = PowNumbers(numberA, numberB);
Console.WriteLine($"{numberA}^{numberB} -> {powNumbers}");

int PowNumbers(int num1, int num2)
{
    if (num2 == 0) return 1;
    else return num1 * PowNumbers(num1, num2 - 1);
}
