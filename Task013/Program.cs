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
    int thirdDigit = number % 10;
    return thirdDigit;
}
else 
 {
   int count = number;
   while (count > 1000) 
   {
        int digit = count % 10;
        count = (count - digit) / 10 ;              
   }
  int thirdDigit = count % 10;    
  return thirdDigit;
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

