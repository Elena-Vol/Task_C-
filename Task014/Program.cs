/*  Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число => {number}");
int resalt = CetNumber (number);

int CetNumber (int num)
{
    int res1 = num % 7;
    int res2 = num % 23;
    if (res1 == 0 && res2 == 0) return 1;
    return 0;
}
if (resalt == 1) Console.WriteLine("Кратно 7 и 23"); 
else Console.WriteLine("Не кратно 7 и 23");








/* Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = GetNumber(number);

int GetNumber(int num)
{
    int res1 = num % 7;
    int res2 = num % 23;
    if (res1 == 0 && res2 == 0) return 1;
    else return 0;
}

if (result == 1) Console.WriteLine("Кратно 7 и 23");
else Console.WriteLine("Не кратно 7 и 23"); */






/* bool Multiple(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Multiple(number);

if (result) Console.WriteLine("да");
else Console.WriteLine("нет"); */