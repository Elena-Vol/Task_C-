﻿/* Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N. */

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0)
{
    int count = 1;
    while (count <= number)
    {
        if (count % 2 == 0)
        {
            Console.Write($"{count} ");
        }
        count = count + 1;
    }
}
else
{
    Console.WriteLine("Введено не корректное число");
}
