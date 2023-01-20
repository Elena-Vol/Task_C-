/* Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

Console.WriteLine("введите число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1) Console.WriteLine("не корректный ввод");
else Squar (num);


void Squar(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"квадрат числа {count, 5} равен {count * count, 5}");
        count++;
    }   
}

