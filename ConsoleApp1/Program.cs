using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;

class program
{


    static void Main(string[] args)
    {

        Draw();
        
       
        
       

    }

    static void Draw()
    {
        //pots
        List<string> pot1 = new List<string>();
        pot1.Add("Qatar");
        pot1.Add("Brazil");
        pot1.Add("Belgium");
        pot1.Add("France");
        pot1.Add("Argentina");
        pot1.Add("England");
        pot1.Add("Spain");
        pot1.Add("Portugal");

        List<string> pot2 = new List<string>();
        pot2.Add("Mexico");
        pot2.Add("Netherlands");
        pot2.Add("Denmark");
        pot2.Add("Germany");
        pot2.Add("Uruguay");
        pot2.Add("Switzerland");
        pot2.Add("United States");
        pot2.Add("Crotia");

        List<string> pot3 = new List<string>();
        pot3.Add("Senegal");
        pot3.Add("IR Iran");
        pot3.Add("Japan");
        pot3.Add("Morocco");
        pot3.Add("Serbia");
        pot3.Add("Poland");
        pot3.Add("South Korea");
        pot3.Add("Tunisia");

        List<string> pot4 = new List<string>();
        pot4.Add("Cameroon");
        pot4.Add("Canada");
        pot4.Add("Ecuador");
        pot4.Add("Saudi Arabia");
        pot4.Add("Ghana");
        pot4.Add("Wales");
        pot4.Add("Costa Rica");
        pot4.Add("Australia");






        // The for loop divides the countries into 8 different groups


        for (int i = 0; i < 8; i++)
        {
            //The letters array is used to update the group names and position in group
            string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };


            int index = Teams.randomSplit(pot1);
            int index2 = Teams.randomSplit(pot2);
            int index3 = Teams.randomSplit(pot3);
            int index4 = Teams.randomSplit(pot4);



            //Qatar will always be in group A, since they are the host nations


            if (i == 0)
            {

                Console.WriteLine($"Group {letters[i]}\r\n");
                Console.WriteLine($"{letters[i]}1 - {pot1[0]}, {letters[i]}2 - {pot2[index2]}, {letters[i]}3 - {pot3[index3]}, {letters[i]}4 - {pot4[index4]}\r\n");

                //removes whichever team was just picked

                pot1.Remove(pot1[0]);
                pot2.Remove(pot2[index2]);
                pot3.Remove(pot3[index3]);
                pot4.Remove(pot4[index4]);
                i++;

            }



            //Fills out the rest of the groups.

            Console.WriteLine($"Group {letters[i]}\r\n");
            Console.WriteLine($"{letters[i]}1 - {pot1[index]}, {letters[i]}2 - {pot2[index2]}, {letters[i]}3 - {pot3[index3]}, {letters[i]}4 - {pot4[index4]}\r\n");

            //removes whichever team was just picked

            pot1.Remove(pot1[index]);
            pot2.Remove(pot2[index2]);
            pot3.Remove(pot3[index3]);
            pot4.Remove(pot4[index4]);


        }

    }





}











