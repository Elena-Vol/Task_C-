/* Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа */

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число => {number}");
int finishnumber = Getnumber(number);
Console.WriteLine($"Конечное число => {finishnumber}");

int Getnumber(int num)
{
    int firstnum = num / 100;
    int secondnum = num % 10;
    int resalt = firstnum * 10 + secondnum;
    return resalt;
}
