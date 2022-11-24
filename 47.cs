/*/Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

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