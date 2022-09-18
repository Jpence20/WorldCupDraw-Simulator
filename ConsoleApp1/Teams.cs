using System;

public class Teams
{
  
    public static int randomSplit(List<string> pot)
    {

        Random rand = new Random();
        int index = rand.Next(pot.Count);
        return index;

    }
   
    
   
    
}
