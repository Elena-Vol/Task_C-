/* Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее */

Console.Write("Введите число ");
int numderA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число ");
int numderB = Convert.ToInt32(Console.ReadLine());
if (numderA > numderB)
{
    Console.WriteLine($"число {numderA} больше числа {numderB} ");
}
else
{
    Console.WriteLine($"число {numderA} меньше числа {numderB} ");
}





