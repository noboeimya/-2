
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] ReturnArray(int size, int left, int right)
{
    double[] numb = new double[size];
    for (int i = 0; i < size; i++)
    {
        numb[i] = Math.Round(new Random().NextDouble() * (right - left) + left, 2);
    }
    return numb;
}

double Maximum(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double Minimum(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
Console.Write("введите размер массива: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("введите конец левого диапазона: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("введите конец правого диапазона: ");
int b = int.Parse(Console.ReadLine()!);
double[] WorkArray = ReturnArray(number, a, b);
Console.WriteLine($" получили массив: [{String.Join(", ", WorkArray)}]");

Console.WriteLine($" наименьший массив: {Minimum(WorkArray)}");
Console.WriteLine($" наибольший массив: {Maximum(WorkArray)}");

double diference = Maximum(WorkArray) - Minimum(WorkArray);
Console.WriteLine($"разницу между максимальным и минимальным элементов массива составило:  {diference}");