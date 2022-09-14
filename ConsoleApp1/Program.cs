using System.Runtime.CompilerServices;

Draw();
void Draw()
{
    //pots for the countries
    String[] pot1 = { "Qatar", "Brazil", "Belgium", "France", "Argentina", "Engalnd", "Spain", "Portugal" };
    String[] pot2 = { "Mexico", "Netherlands", "Denmark", "Germany", "Uruguay", "Switzerland", "United States", "Crotia" };
    String[] pot3 = { "Senegal", "IR Iran", "Japan", "Morocco", "Serbia", "Poland", "South Korea", "Tunisia" };
    String[] pot4 = { "Cameroon", "Canda", "Ecuador", "Saudi Arabia", "Ghana", "Wales", "Costa Rica", "Australia" };

   

    // The for loop divides the countries into 8 different groups


    for (int i = 0; i < 8;i++)
    {
        //The letters array is used to update the group names
        string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };
        
            int index = randomSplit(pot1, pot2, pot3, pot4);


        //Qatar will always be in group A, since they are the host nations


        if (i==0)
        {
            
            Console.WriteLine($"Group {letters[i]}\r\n");
            Console.WriteLine($"{pot1[0]}, {pot2[index]}, {pot3[index]}, {pot4[index]}\r\n");
            i++;
        }
        //Fills out the rest of the groups.
            Console.WriteLine($"Group {letters[i]}\r\n");
            Console.WriteLine($"{pot1[index]}, {pot2[index]}, {pot3[index]}, {pot4[index]}\r\n");
        

       
    }

    

}
//randomly picks a number that is associated with a country in the pot
int randomSplit(string[] pot1, string[] pot2, string[] pot3, string[] pot4)
{
    
    Random rand = new Random();
    int index = rand.Next(pot1.Length);
    return index;
   
}


