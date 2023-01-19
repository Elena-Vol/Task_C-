/* Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

Console.Write("Введите первое число ");
int numderA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int numderB = Convert.ToInt32(Console.ReadLine());

int resalt = Getnumber (numderA, numderB);

int Getnumber (int num1, int num2)
{
    if (num1 * num1 == num2) return 1;
    else if (num2 * num2 == num1) return 1;
    else  return 0;
}

if (resalt ==1) Console.Write("Кратно");
else Console.Write("не кратно");






/* Console.Write("Введите целое первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = GetNumber(firstNumber, secondNumber);

int GetNumber(int num1, int num2)
{
    if (num1 * num1 == num2) return 1;
    else if (num2 * num2 == num1) return 1;
    else return 0;
}

if (result == 1) Console.WriteLine("Кратно");
else Console.WriteLine("Некратно"); */






/* bool Multiple(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Multiple(number);

if (result) Console.WriteLine("да");
else Console.WriteLine("нет");

bool Square(int number1, int number2)
{
    return number1 * number1 == number2 || number2 * number2 == number1;
}

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = Square(number1, number2);

if (result) Console.WriteLine("да"); // - последняя строка
else Console.WriteLine("нет"); */    // - последняя строка

// Console.WriteLine(result ? "да" : "нет");

// или

// string res = result ? "да" : "нет";
// Console.WriteLine(res);

