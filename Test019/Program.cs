/* Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите любое число ");
int num = Convert.ToInt32(Console.ReadLine());

int module = Math.Abs(num);
int turnover = Turnover(module);
if (module == turnover)
{
    Console.WriteLine($"Число {num} является палиндромом");
    return;
}
Console.WriteLine($"Число {num} не является палиндромом");



int Turnover(int number)
{
    int result = 0;

    while (number > 0)
    {
        result *= 10;
        result += number % 10;
        number /= 10;
    }
    return result;
}
