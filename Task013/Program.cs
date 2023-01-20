/* Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int ThirdDigit (int number)
{
if (number > 99 && number <1000)
{
    return number % 10;
}
else 
 {
   // int count = number;
   while (number > 1000) 
   {
        // int digit = number % 10;
        number = (number - number % 10) / 10 ;              
   }
  // int thirdDigit = number % 10;    
  return number % 10;
 }
}

Console.Write("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

int module = Math.Abs(num);
if (module < 99 ) Console.Write("Третьей цифры нет");
else 
{
    int result = ThirdDigit (module);
    Console.WriteLine($"третья цифра этого числа: {result}");
}

