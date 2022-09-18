using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class program
{


    static void Main(string[] args)
    {
        
        Draw();

    }



    static void Draw()
    {

        String[] pot1 = { "Qatar", "Brazil", "Belgium", "France", "Argentina", "Engalnd", "Spain", "Portugal" };
        String[] pot2 = { "Mexico", "Netherlands", "Denmark", "Germany", "Uruguay", "Switzerland", "United States", "Crotia" };
        String[] pot3 = { "Senegal", "IR Iran", "Japan", "Morocco", "Serbia", "Poland", "South Korea", "Tunisia" };
        String[] pot4 = { "Cameroon", "Canda", "Ecuador", "Saudi Arabia", "Ghana", "Wales", "Costa Rica", "Australia" };

        
        // The for loop divides the countries into 8 different groups


        for (int i = 0; i < 8; i++)
        {
            //The letters array is used to update the group names
            string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };

            
            int index = Teams.randomSplit(pot1);
            int index2 = Teams.randomSplit(pot2);
            int index3 = Teams.randomSplit(pot3);
            int index4 = Teams.randomSplit(pot4);


            //Qatar will always be in group A, since they are the host nations


            if (i == 0)
            {

                Console.WriteLine($"Group {letters[i]}\r\n");
                Console.WriteLine($"{pot1[0]}, {pot2[index2]}, {pot3[index3]}, {pot4[index4]}\r\n");


                i++;
            }



            //Fills out the rest of the groups.
            Console.WriteLine($"Group {letters[i]}\r\n");
            Console.WriteLine($"{pot1[index]}, {pot2[index2]}, {pot3[index3]}, {pot4[index4]}\r\n");



        }



    }

   
}











