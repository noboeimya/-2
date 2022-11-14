/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
 число A в натуральную степень B.*/
int DegreeNum ( int A, int B)
{
    int N =1;
    for (int i = 1; i <= B; i ++)
    {
        N = N * A;
    }
    return N;
}
Console.Clear();
Console.Write("введите число А= ");
int numb1 = int.Parse(Console.ReadLine()!);
Console.Write("введите число B= ");
int numb2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"результат возведения {numb1} в степень числа {numb2} равен {DegreeNum(numb1,numb2)}");
