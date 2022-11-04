/*//Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/
        Console.WriteLine("Введите пятизначное число");
            numStr = Console.ReadLine();

            char[] numStrChar = numStr.ToCharArray();
            char[] numStrRev = new char[5];

            error = true;
            count = 0;

            for (int i = 0; i < numStr.Length && error; i++)
            {
                if (Char.IsDigit(numStr[i]) != true) error = false;
                count++;

                numStrRev[i] = numStrChar[numStr.Length - i - 1];
                Console.WriteLine(numStrRev[i]);
            }
