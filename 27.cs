//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int CoutingNum (int i)
{
int sum = 0;
while (i > 0)
  {
  sum = sum + i % 10;
  i = i / 10;
  }
 return sum;
}
Console.Clear();
Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"сумма всех цифр в числе равна:{CoutingNum(number)}");