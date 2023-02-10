/* Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9 */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = number*(-1);
int summ = SumOfDigits(number);
Console.WriteLine(summ);


int SumOfDigits(int num)
{
    if (num < 10) return num;
    else return num % 10 + SumOfDigits(num / 10);
}

/* 
int SumOfDigits(int num)
{
    int sum = default;
    if (num > 9)
    {
        sum = SumOfDigits(num / 10) + num%10;
        return sum;
    }
    else
        return num;
}
 */