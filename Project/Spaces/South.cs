/*
Look center class for code explantion
*/

public class South : Space
{
    public South(String name) : base(name)
    {
        
    }
    public static bool hasVisitedSouth;

    public override void Welcome()
    {
        if (hasVisitedSouth == false)
        {
            Utility.SlowPrint($"Dette er første gang, du besøger {name}. Du finder en avis og begynder at læse den.", 20);
            Utility.SlowPrint("Ulempen ved træbaseret emballage er genanvendelsesprocessen, hvor fibrene kun kan genbruges op til syv gange.", 30);
            Utility.SlowPrint("En anden ulempe er brugen af PFAS-kemikalier i mange papir- og papproduktioner. PFAS er fluorforbindelser, der giver en vandafvisende effekt på tøj.", 30);
            Utility.SlowPrint("Nogle typer er skadelige for mennesker og kan forårsage leverskader og fertilitetsproblemer, og alle er svære at nedbryde i naturen.", 30);
            hasVisitedSouth = true;
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



    public static void QuestionSouth()
    {
        if (hasVisitedSouth == true)
        {
            Utility.SlowPrint("Ulemper ved træbaseret emballage", 20);
            Utility.SlowPrint("Er der ulemper ved træbaseret emballage?", 20);
            Utility.SlowPrint("A: Ja, det kan ikke genbruges.", 20);
            Utility.SlowPrint("B: Nej.", 20);
            Utility.SlowPrint("C: Ulemperne ved træbaseret emballage er hvor meget energi der bliver brugt til at producere den.", 20);
            Utility.SlowPrint("D: Ulemperne ved træbaseret emballage at fibre der bliver produceret fra træ er kun genanvendelig op til syv gange, og den anden ulempe er brugen af PFAS-kemikalier i produktionen.", 20);
            Utility.SlowPrint("Vælg enten A, B, C eller D.", 20);

            bool hasAnswered = false;

            while (!hasAnswered)
                {
                    string? answer = Console.ReadLine().ToLower();
                    switch(answer)
                    {
                        case "a":
                            Console.WriteLine("Forkert");
                            hasAnswered = true;
                            break;

                        case "b":
                            Console.WriteLine("Forkert");
                            hasAnswered = true;
                            break;

                        case "c":
                            Console.WriteLine("Forkert");
                            hasAnswered = true;
                            break;

                        case "d":
                            Console.WriteLine("Korrekt!");
                            hasAnswered = true;
                            break;

                        default:
                            Console.WriteLine("Dette er ikke et svar. Prøv igen.");
                            break;
                    }
                }
        }
    }
}
