/*
Look center class for code explantion
*/
public class Forest : Space
{
    public Forest(String name) : base(name)
    {

    }
    public static bool hasVisitedForest;
    public override void Welcome()
    {
        if (hasVisitedForest == false)
        {
            Utility.SlowPrint($"Dette er første gang, du besøger {name}. Du finder en avis og begynder at læse den.", 20);
            Utility.SlowPrint("Selvom emballage og indpakning af pap og papir kan genanvendes, og træressourcer teknisk set er uendelige,", 30);
            Utility.SlowPrint("er vi begrænset af, at vi fælder omkring 10 milliarder flere træer hvert år, end vi planter. De træer, vi planter i dag, vil først kunne bruges om 10-20 år.", 30);
            Utility.SlowPrint("Det betyder, at en tilsyneladende uendelig og genanvendelig ressource stadig kan slippe op over tid.", 30);
            hasVisitedForest = true;
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
            Utility.SlowPrint("Du er tilbage i skoven, hug nogle træer eller saml nogle frugter.", 30);
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
