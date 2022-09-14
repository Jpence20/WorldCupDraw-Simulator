using System.Runtime.CompilerServices;

Draw();
void Draw()
{//pots for the countries
    String[] pot1 = { "Qatar", "Brazil", "Belgium", "France", "Argentina", "Engalnd", "Spain", "Portugal" };
    String[] pot2 = { "Mexico", "Netherlands", "Denmark", "Germany", "Uruguay", "Switzerland", "United States", "Crotia" };
    String[] pot3 = { "Senegal", "IR Iran", "Japan", "Morocco", "Serbia", "Poland", "South Korea", "Tunisia" };
    String[] pot4 = { "Cameroon", "Canda", "Ecuador", "Saudi Arabia", "Ghana", "Wales", "Costa Rica", "Australia" };

    String[] Groups = { "A", "B", "C", "D", "E", "F", "G", "H" };

    // the for loop divides the countries into different groups
    for (int i = 0; i < 8;i++)
    {
        string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };
        
            int index = randomSplit(pot1, pot2, pot3, pot4);


            //pot 1 in group A is the only one that will have a fixed country as Qatar is the host nation, so they get put in group A
            Console.WriteLine("Group " + letters[i]);
            Console.WriteLine($"{pot1[0]},{pot2[index]},{pot3[index]},{pot4[index]}");
          

       
    }

    

}
//randomly picks a number that is associated with a country in the pot
int randomSplit(string[] pot1, string[] pot2, string[] pot3, string[] pot4)
{
    
    Random rand = new Random();
    int index = rand.Next(pot1.Length);
    return index;
}


