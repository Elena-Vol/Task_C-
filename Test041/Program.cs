/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

int[] GetArray (int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Ведите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int PositiveAmount (int[] array)
{
    int positiveAmount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positiveAmount ++;
    }
    return positiveAmount;
}

Console.WriteLine("Ведите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = GetArray(number);
PrintArray(arr);
int positiveAmount = PositiveAmount(arr);
Console.WriteLine($"Количество чисел больше нуля в массиве: {positiveAmount}"); 