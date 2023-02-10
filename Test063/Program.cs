/* Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */




Console.WriteLine("введите число ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers (number);

void NaturalNumbers (int num)
{
    if (num == 0) return;
    // Console.Write($"{num} ");
    NaturalNumbers (num -1);                  // "хвостовая" реккурсия, если стоит в конце. А вообще пока она не отработает все циклы вниз по коду не идет выполнение
    Console.Write($"{num} ");                 // рекурсия работает со stack (это как перебор стопки книг!) 
}








