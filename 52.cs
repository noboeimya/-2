//задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int num1, int num2, int min, int max)
{
    Random rnd = new Random();
    int[,] newArray = new int[num1, num2];
    for (int i = 0; i < num1; i++)
    {
        for (int j = 0; j < num2; j++)
        {
            newArray[i, j] = rnd.Next(min, max + 1);
        }

    }
    return newArray;
}
void PrintIntArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.WriteLine($" {inArray[i, j],5}");
        }
    }
}
void ColumnArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ += array[i, j];
        }
        summ /= array.GetLength(0);
        Console.Write($" {summ,5} ");
    }
}
int[,] myArray = GetArray(3, 3, -4, 4);
PrintIntArray(myArray);
Console.WriteLine("--------------"); 

ColumnArray(myArray);