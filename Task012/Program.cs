/* Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */

Console.Write("Введите первое число ");
int numderA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int numderB = Convert.ToInt32(Console.ReadLine());

int remains = DivAB (numderA, numderB); // остаток от деледния

int DivAB (int nam1, int nam2)
{
    int resalt = nam1 % nam2;
    return resalt;
}

if (remains == 0)
Console.WriteLine($"Число {numderA} кратно числу {numderB}");
else 
Console.WriteLine($"Число {numderA} не кратно числу {numderB}, остаток {remains}");






