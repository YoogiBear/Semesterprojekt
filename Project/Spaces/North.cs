/*
Look center class for code explantion
*/

public class North : Space
{
    public North(String name) : base(name)
    {
        
    }
    private bool hasVisited;

    public override void Welcome()
    {
        if (hasVisited == false)
        {
            Utility.SlowPrint($"Dette er første gang, du besøger {name}. Du finder en avis og begynder at læse den.", 20);
            Utility.SlowPrint("Det bliver derfor tydeligt, at løsningen på emballageproblemet kræver en bredere indsats,", 30);
            Utility.SlowPrint("hvor både producenter og forbrugere spiller en rolle", 30);
            Utility.SlowPrint("i at finde en balance mellem funktionalitet og bæredygtighed.", 30);
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
            Utility.SlowPrint("Du er tilbage i den nordlige del af øen.", 30);
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
