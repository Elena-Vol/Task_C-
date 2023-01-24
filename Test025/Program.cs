/* Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Write("Введите любое число ");
double numberA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите натуральное число ");
int numberB = Convert.ToInt32(Console.ReadLine());

double module = Math.Abs(numberA);

if (numberB > 0)
{
    double degree = Degree(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени {numberB}  = {degree}");
}
else
    Console.WriteLine("Введено некорректное значение");

double Degree(double numA, int numB)

{
    double resultDeg = numA;

    for (int i = 1; i < numB; i++)
    {
        resultDeg = resultDeg * numA;
    }
    double resultDegRound = Math.Round(resultDeg, 2, MidpointRounding.ToZero);
    return resultDegRound;
}


