/* Напишите программу, которая на вход принимает два
числа и проверяет, является ли первое число квадратом
второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет */

Console.Write("Введите число ");
int numderA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число ");
int numderB = Convert.ToInt32(Console.ReadLine());
if (numderA == numderB * numderB)
{
    Console.WriteLine($"число {numderA} является квадратом числа {numderB} ");
}
else
{
    Console.WriteLine($"число {numderA} не является квадратом числа {numderB} ");
}

