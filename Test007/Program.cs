/* Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа. */

Console.Write("Введите трехзначное число ");
int numder = Convert.ToInt32(Console.ReadLine());

int lastDigit = numder % 10;

Console.WriteLine($"цифра {lastDigit} является последней");


