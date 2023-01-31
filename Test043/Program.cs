/* Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями 
      y = k1 * x + b1,                  => x = (b2 - b1) / (k1 - k2)
      y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double[] PointIntersectionXY(int bc1, int kc1, int bc2, int kc2)
{
    double[] array = new double[2];
    double x = Convert.ToDouble(bc2 - bc1) / (kc1 - kc2);
    double y = Convert.ToDouble(kc1 * x + bc1);
    array[0] = x;
    array[1] = y;
    return array;
}


Console.WriteLine("Ведите четыре числа, определяющие две наши переменные: ");
int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"первая переменная: y = {k1} * x + {b1}");
Console.WriteLine($"вторая переменная: y = {k2} * x + {b2}");

if ((k1 == k2) && (b1 == b2))

    Console.WriteLine("Прямые совпадают");

else if (k1 == k2)

    Console.WriteLine("Прямые параллельны");

else
{
    double[] pointIntersection = PointIntersectionXY(b1, k1, b2, k2);
    Console.Write($"координаты точки пересечения двух прямых: ");
    PrintArrayDouble(pointIntersection);
}
