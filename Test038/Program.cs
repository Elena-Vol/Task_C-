/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);         
    }
    return array;
}

void PrintArrayDouble (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if (i< array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


double GetDifferMinMax (double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return max - min; // differMinMax = max - min; 
}


double[] arr = CreateArrayRndDouble(5, 0, 100);
PrintArrayDouble(arr);
double differMinMax = Math.Round(GetDifferMinMax (arr), 2);
Console.WriteLine($"разница между max и min числом в массиве равна: {differMinMax}");  
