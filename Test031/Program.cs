/* Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и 
положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна -20. */

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if (i< array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int GetSumNegativ (int[] array)
{
    int sum = default; // значение по умолчанию, т.е. ноль  int sum = 0
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }
    return sum;
}

int GetSumPozitiv (int[] array)
{
    int sum = default; // значение по умолчанию, т.е. ноль  int sum = 0
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];
    }
    return sum;
}

int[] arr = CreateArrayRndInt(12, 100, 1000);
PrintArray(arr); 
int sumPozitiv = GetSumPozitiv (arr);
int sumNegativ = GetSumNegativ (arr);
Console.WriteLine($"сумма положительных элементов в массиве: {sumPozitiv}");
Console.WriteLine($"сумма отрицательных элементов в массиве: {sumNegativ}");


int[] GetSumALL(int[] array)
{
    int sumNegativ = 0;
    int sumPozitiv = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPozitiv += array[i];
        if (array[i] < 0) sumPozitiv += array[i];
    }
    return new int[] {sumPozitiv, sumNegativ};
}

int[] getSumALL = GetSumALL(arr);
PrintArray(arr); 
Console.WriteLine($"сумма положительных элементов в массиве: {getSumALL [0]}");
Console.WriteLine($"сумма отрицательных элементов в массиве: {getSumALL [1]}");


/* 
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray (int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
} */




/* 
  кому  Все
int GetSumNegativeElem (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i]; // sum = sum + array[i]
    }
    return sum;
}

int GetSumPositiveElem (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i]; // sum = sum + array[i]
    }
    return sum;
}
int[] GetSumPositiveNegativeElem(int[] array)
{
    int sumNegative = 0;
    int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sumPositive += array[i];
        if(array[i] < 0) sumNegative += array[i];
    }
    return new int[]{sumPositive, sumNegative};
}


int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int sumNegativeElem = GetSumNegativeElem(arr);
int sumPositiveElem = GetSumPositiveElem(arr);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");
Console.WriteLine();
int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativeElem[1]}"); */