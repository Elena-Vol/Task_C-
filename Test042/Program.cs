/* Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

     // Делим на два, потом записываем результаты в обратном порядке

int GetBinary(int num)
{
    int bin
     = 0;
    int count = 1;

    while (num > 0)
    {
        bin
         = bin
         + num % 2 * count;
        num = num / 2;
        count *=  10;
    }
    return bin;
}


Console.WriteLine("Ведите число ");
int number = Convert.ToInt32(Console.ReadLine());
int binary = GetBinary (number);
Console.WriteLine(binary);








