/*
Look center class for code explantion
*/

public class East : Space
{
   public East(String name) : base(name)
    {
        
    }
   public bool hasVisited;

    public override void Welcome()
    {
        if (hasVisited == false)
        {
            Utility.SlowPrint($"Dette er første gang, du besøger {name}. Du finder en avis og begynder at læse den.", 20);
            Utility.SlowPrint("Emballage har en vigtig funktion, da den beskytter produkter under transport og forlænger deres holdbarhed, hvilket hjælper med at reducere madspild.", 30);
            Utility.SlowPrint("Dette skaber et dilemma mellem behovet for funktionel emballage", 30);
            hasVisited = true;
            Utility.SlowPrint("Du kan se disse stier:", 20);
            HashSet<string> exits = edges.Keys.ToHashSet();
            foreach (String exit in exits)
            {
                Console.WriteLine(" - " + exit);
                Thread.Sleep(500);
            }
            Utility.SlowPrint("Hvad vil du gerne gøre nu?", 20);
        }
        else
        {
            Utility.SlowPrint("Du er tilbage i den østlige del af øen.", 30);
            Utility.SlowPrint("Du kan se disse stier:", 20);
            HashSet<string> exits = edges.Keys.ToHashSet();
            foreach (String exit in exits)
            {
                Console.WriteLine(" - " + exit);
                Thread.Sleep(500);
            }
                Utility.SlowPrint("Hvad vil du gerne gøre nu?", 20);

        }
    }
}
