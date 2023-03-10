/* Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N. В
ыполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0) Console.WriteLine($"введены некорректные значения");
else
{
int summOfDigits = SumOfDigits(m, n);
Console.WriteLine($"сумма натуральных элементов в промежутке от {m} до {n} равна: {summOfDigits}");
}


int SumOfDigits(int numM, int numN)
{
    if (numM == numN) return numM;
    else if (numM < numN) return numM + SumOfDigits(numM + 1, numN);

    else return numN + SumOfDigits(numM, numN + 1);
}







