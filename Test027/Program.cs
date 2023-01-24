/* Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int module = Math.Abs(number);

int sumDigit = SumDigit(module);
Console.WriteLine($"Сумма цифр числа {number} = {sumDigit}");

int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int digit = num % 10;
        num = num / 10;
        sum = sum + digit;
    }
    return sum;
}
