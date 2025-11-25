/*
Look center class for code explantion
*/

public class East : Space
{
   public East(String name) : base(name)
    {
        
    }
   public static bool hasVisitedEast;

    public override void Welcome()
    {
        if (hasVisitedEast == false)
        {
            Utility.SlowPrint($"Dette er første gang, du besøger {name}. Du finder en avis og begynder at læse den.", 20);
            Utility.SlowPrint("Emballage har en vigtig funktion, da den beskytter produkter under transport og forlænger deres holdbarhed, hvilket hjælper med at reducere madspild.", 30);
            Utility.SlowPrint("Dette skaber et dilemma mellem behovet for funktionel emballage", 30);
            hasVisitedEast = true;
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
    public static void QuestionEast()
    {
        if (hasVisitedEast == true)
        {
            Utility.SlowPrint("Emballagens funktion til madvarer", 20);
            Utility.SlowPrint("Er emballage altid dårlig ift. opbevaring af mad?", 20);
            Utility.SlowPrint("A: Ja, altid.", 20);
            Utility.SlowPrint("B: Så længe det er lavet af pap, er det okay.", 20);
            Utility.SlowPrint("C: Emballage kan være brugbart til at transportere mad og forlænge dens holdbarhed.", 20);
            Utility.SlowPrint("D: Det er kun dårligt, hvis emballagen er lavet af plastik.", 20);
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
