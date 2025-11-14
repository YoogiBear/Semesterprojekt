/*
Look center class for code explantion
*/

public class South : Space
{
    public South(String name) : base(name)
    {
        
    }
    private bool hasVisited;

    public override void Welcome()
    {
        if (hasVisited == false)
        {
            Utility.SlowPrint($"Dette er første gang, du besøger {name}. Du finder en avis og begynder at læse den.", 20);
            Utility.SlowPrint("Ulempen ved træbaseret emballage er genanvendelsesprocessen, hvor fibrene kun kan genbruges op til syv gange.", 30);
            Utility.SlowPrint("En anden ulempe er brugen af PFAS-kemikalier i mange papir- og papproduktioner. PFAS er fluorforbindelser, der giver en vandafvisende effekt på tøj.", 30);
            Utility.SlowPrint("Nogle typer er skadelige for mennesker og kan forårsage leverskader og fertilitetsproblemer, og alle er svære at nedbryde i naturen.", 30);
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
            Utility.SlowPrint("Du er tilbage i den sydlige del af øen.", 30);
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
