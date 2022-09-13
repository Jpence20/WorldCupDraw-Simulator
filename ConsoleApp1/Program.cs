
Draw();

void Draw()
{


    String[] pot1 = { "Qatar", "Brazil", "Belgium", "France", "Argentina", "Engalnd", "Spain", "Portugal" };
    String[] pot2 = { "Mexico", "Netherlands", "Denmark", "Germany", "Uruguay", "Switzerland", "United States", "Crotia" };
    String[] pot3 = { "Senegal", "IR Iran", "Japan", "Morocco", "Serbia", "Poland", "South Korea", "Tunisia" };
    String[] pot4 = { "Cameroon", "Canda", "Ecuador", "Saudi Arabia", "Ghana", "Wales", "Costa Rica", "Australia" };

    String[] Groups = { "A", "B", "C", "D", "E", "F", "G", "H" };

    Random rand = new Random();
    int index = rand.Next(pot1.Length);
    Console.WriteLine($"{pot1[index]}");
}