﻿using System.Runtime.CompilerServices;

Draw();
void Draw()
{
    String[] pot1 = { "Qatar", "Brazil", "Belgium", "France", "Argentina", "Engalnd", "Spain", "Portugal" };
    String[] pot2 = { "Mexico", "Netherlands", "Denmark", "Germany", "Uruguay", "Switzerland", "United States", "Crotia" };
    String[] pot3 = { "Senegal", "IR Iran", "Japan", "Morocco", "Serbia", "Poland", "South Korea", "Tunisia" };
    String[] pot4 = { "Cameroon", "Canda", "Ecuador", "Saudi Arabia", "Ghana", "Wales", "Costa Rica", "Australia" };

    String[] Groups = { "A", "B", "C", "D", "E", "F", "G", "H" };


    for (int i = 0; i < 8;i++)
    {
        if (i == 1)
        {
            int index = randomSplit(pot1, pot2, pot3, pot4);

            Console.WriteLine("Group A");
            Console.WriteLine($"{pot1[index]},{pot2[index]},{pot3[index]},{pot4[index]}");
           
        }
        if (i == 2)
        {
            int index = randomSplit(pot1, pot2, pot3, pot4);

            Console.WriteLine("Group B");
            Console.WriteLine($"{pot1[index]},{pot2[index]},{pot3[index]},{pot4[index]}");
        }
        if (i == 3)
        {
            int index = randomSplit(pot1, pot2, pot3, pot4);

            Console.WriteLine("Group C");
            Console.WriteLine($"{pot1[index]},{pot2[index]},{pot3[index]},{pot4[index]}");
        }
        if (i == 4)
        {
            int index = randomSplit(pot1, pot2, pot3, pot4);

            Console.WriteLine("Group D");
            Console.WriteLine($"{pot1[index]},{pot2[index]},{pot3[index]},{pot4[index]}");
        }
        if (i == 5)
        {
            int index = randomSplit(pot1, pot2, pot3, pot4);

            Console.WriteLine("Group E");
            Console.WriteLine($"{pot1[index]},{pot2[index]},{pot3[index]},{pot4[index]}");
        }
        if (i == 6)
        {
            int index = randomSplit(pot1, pot2, pot3, pot4);

            Console.WriteLine("Group F");
            Console.WriteLine($"{pot1[index]},{pot2[index]},{pot3[index]},{pot4[index]}");
        }
        if (i == 7)
        {
            int index = randomSplit(pot1, pot2, pot3, pot4);

            Console.WriteLine("Group G");
            Console.WriteLine($"{pot1[index]},{pot2[index]},{pot3[index]},{pot4[index]}");
        }
        if (i == 8)
        {
            int index = randomSplit(pot1, pot2, pot3, pot4);

            Console.WriteLine("Group H");
            Console.WriteLine($"{pot1[index]},{pot2[index]},{pot3[index]},{pot4[index]}");
        }
    }

    

}
int randomSplit(string[] pot1, string[] pot2, string[] pot3, string[] pot4)
{
    
    Random rand = new Random();
    int index = rand.Next(pot1.Length);
    return index;
}

