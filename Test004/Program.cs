/* Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел */

Console.Write("Введите число ");
int numderA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число ");
int numderB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число ");
int numderC = Convert.ToInt32(Console.ReadLine());

int max = numderA;

if (numderB > max) max = numderB;
if (numderC > max) max = numderC;

Console.Write("max = ");
Console.WriteLine(max);