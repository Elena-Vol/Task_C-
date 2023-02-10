﻿/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

/* функция ack(n, m)
   если n = 0
     вернуть m + 1
   иначе, если m = 0
     вернуть ack (n - 1, 1)
   еще
     вернуть ack(n - 1, ack (n, m - 1)) */



int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((m == 0) && (m == 0))         
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.WriteLine("Введите  первое не отрицательное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе не отрицательное число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA < 0) numA = numA * (-1);
if (numB < 0) numB = numB * (-1);

int akkerman = Akkerman(numA, numB);
Console.WriteLine($"вычисления функции Аккермана двух чисел {numA} {numB} равно: {akkerman}");