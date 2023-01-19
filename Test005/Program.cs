/* Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа в промежутке от -N до N. */

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >0)
{
    int count = -number;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count = count + 1;
    }
}
else
{
    Console.WriteLine("Введено не корректное число");
}