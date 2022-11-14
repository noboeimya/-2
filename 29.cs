//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран./CreateArray/

int CreateArray (int [] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i ++)
    {
        array[i]= int.Parse(Console.ReadLine());
    }
    return length;
}
int PrintArray(int[] col)
{
    int count = col.Length;
    for (int index = 0; index < count - 1; index ++)
    {
        Console.Write($"{col[index]},");
    }
    Console.Write($"{col[7]},");
    return count;
}
Console.Clear();
Console.WriteLine("вводите массив ");
int [] array = new int [8];
CreateArray(array);
Console.Write("массив: [");
PrintArray(array);
Console.Write("]");