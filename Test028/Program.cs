/* Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

Console.Write("Введите целое положительное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int product = Factor(number);
    Console.Write($"произведение цифр : {product}");
}
else Console.Write("Введено не коректное число");

int Factor(int num)
{
    int factor = 1;
    for (int i = 1; i <= num; i++)
    {
        factor = factor * i;
    }
    return factor;
}