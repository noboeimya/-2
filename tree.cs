// елочка//
int Tree(int Z)
{
    for (int i = 1; i < Z; i ++)
    {
        for (int m = 1; m <= Z + i; m ++)
        {
            if ( m <= Z - i + 1)
            {
                Console.Write(" ");
            }
            else
            Console.Write("^");
        }
        Console.Write("\n");
    }
    return Z;
}

Console.Clear();
Console.WriteLine("выбирай высоту елки,пока не началось: ");
int Z = int.Parse(Console.ReadLine());
Console.WriteLine();
Tree (Z);
Console.WriteLine();

