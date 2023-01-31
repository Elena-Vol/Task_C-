/* Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.*/
     //Теорема о неравенстве треугольника: каждая сторона треугольника
     //меньше суммы двух других сторон. 

bool GetTriangle(int A, int B, int C)
{
    return A < (B+C) && B < (A+C) && C < (B+A);
    // return A > (B+C) || B > (A+C) || C > (B+A);
}


Console.WriteLine("введите длинну трех сторон треугольника");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(GetTriangle(a, b, c)  ? "да" : "нет");
// Console.WriteLine(GetTriangle(a, b, c)  ? "нет" : "да");





/* int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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

void ReverseArray (int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length -1 - i] = temp;
    }
}


int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
ReverseArray (arr);
PrintArray(arr);
Array.Reverse(arr);
PrintArray(arr);
 */