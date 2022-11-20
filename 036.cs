/*Задача 36: 
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
 стоящих на нечётных позициях.*/

int[] Finding_Of_Num(int size, int LevtValue, int RightValue)
{
    int[] vector = new int[size];
    for (int i = 1; i < size; i++)
    {
        vector[i] = new Random().Next(LevtValue, RightValue + 1);
    }
    return vector;
}

int AdditionElement(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}
Console.Clear();
Console.Write("вводим размер массива: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("вводим значение левого конца диапазона: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("вводим значение правого конца диапазона: ");
int b = int.Parse(Console.ReadLine()!);
int[] WorkArray = Finding_Of_Num(number, a, b);
Console.WriteLine($"получили массив: [{String.Join(",", WorkArray)}]");
Console.WriteLine($"ссумма нечетных элементов массива ровна: {AdditionElement(WorkArray)}");