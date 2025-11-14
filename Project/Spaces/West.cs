/*
Look center class for code explantion
*/

public class West : Space
{
    public West(String name) : base(name)
    {

    }
    public bool hasVisited;

    public override void Welcome()
    {
        if (hasVisited == false)
        {
            Utility.SlowPrint($"Dette er første gang, du besøger {name}. Du finder en avis og begynder at læse den.", 20);
            Utility.SlowPrint("Ulempen ved træbaseret emballage ligger i genanvendelsesprocessen, hvor fibrene kan genbruges maksimalt syv gange.", 30);
            Utility.SlowPrint("En anden ulempe er brugen af PFAS-stoffer i mange papir- og papproduktioner.", 30);
            Utility.SlowPrint("PFAS er en gruppe fluorforbindelser, som blandt andet giver en vandafvisende effekt på tøj.", 30);
            Utility.SlowPrint("Nogle typer er skadelige for mennesker og kan forårsage leverskader og fertilitetsproblemer, men de deler alle den egenskab, at de er svære at nedbryde i naturen.", 30);
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
            Utility.SlowPrint("Du er tilbage i den vestlige del af øen.", 30);
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
