using System;

public class Teams
{
  
    public static int randomSplit(string[] pot)
    {

        Random rand = new Random();
        int index = rand.Next(pot.Length);
        return index;

    }
    public static void IsDrawn()
    {

    }


}
