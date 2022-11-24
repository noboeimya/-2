/*Задача 50. Напишите программу, которая на вход принимает число и ищет его в двумерном массиве.
 Программа должна возвращать значение позиции (номер строки и столбца) этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/
double[,] GetArray(int line, int post, double minMeaning, double maxMeaning)
{
    double[,] result = new double[line, post];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < post; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * (maxMeaning - minMeaning) + minMeaning, 3);
        }
    }
    return result;
}
void PrintArray(double[,] array)
{
    Console.WriteLine("Двумерный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("задайте количество строк m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("задайте количество столбцов n = ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("введите нижнюю границу диапазона элементов массива: ");
double last = double.Parse(Console.ReadLine()!);
Console.Write("введите верхнюю границу диапазона элементов массива: ");
double elementary = double.Parse(Console.ReadLine()!);

double[,] workingArray = GetArray(m, n, last, elementary);
PrintArray(workingArray);

void refungNumber(double [,] array)
{
    Console.Write("введите искомый элемент массива: ");
    double desiredElement = double.Parse(Console.ReadLine()!);
    double index1 = -1;
    double index2 = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j ++)
        {
            if (array[i, j] == desiredElemen)
            {
              double desiredElemen = array[i, j];
              index1 = i;
              index2 = j;
            }
            return desiredElemen;
        }
    }
Console.Write($"'элемент {desiredElemen} находится в {index1}-й строке;{index2}-м столбце ");
}
Console.Clear();
