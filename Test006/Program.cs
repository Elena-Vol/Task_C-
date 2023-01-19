/*  Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка) */

Console.Write("Введите число ");
int numder = Convert.ToInt32(Console.ReadLine());

if (numder % 2 == 0)
{
    Console.WriteLine($"число {numder} является четным");
}
else
{
    Console.WriteLine($"число {numder} является НЕчетным");
}

