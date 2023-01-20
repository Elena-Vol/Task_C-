/* Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("введите число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1) Console.WriteLine("не корректный ввод");
else Squar (num);


void Squar(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"куб числа {count, 5} равен {count * count * count, 5}");
        count++;
    }   
}

