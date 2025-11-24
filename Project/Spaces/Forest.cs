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


    public static void QuestionForest()
    {
        if (hasVisitedForest == true)
        {
            Utility.SlowPrint("Uendelig og genanvendelig ressource", 20);
            Utility.SlowPrint("Hvorfor er det et problem at bruge træer til vores emballage?", 20);
            Utility.SlowPrint("A: Pap og træ kan ikke genanvendes.", 20);
            Utility.SlowPrint("B: Træer er en meget begrænset ressource", 20);
            Utility.SlowPrint("C: Træer kan blive en begrænset ressource, hvis vi fælder for mange træer.", 20);
            Utility.SlowPrint("D: Det er svært at fælde træer.", 20);
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
                            Console.WriteLine("Korrekt!");
                            hasAnswered = true;
                            break;

                        case "d":
                            Console.WriteLine("Forkert");
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
