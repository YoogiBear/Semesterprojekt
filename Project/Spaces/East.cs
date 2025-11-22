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
            Utility.SlowPrint("Emballage beskytning af mad:", 20);
            Utility.SlowPrint("Er emballage altid dårlig i forhold til opbevaring af mad?", 20);
            Utility.SlowPrint("a. Ja.", 20);
            Utility.SlowPrint("b. Nej, den er ok så længe emballagen er lavede af pap.", 20);
            Utility.SlowPrint("c. Emballage kan være brugebart for at transportere mad og forlænge dens holdbarhed.", 20);
            Utility.SlowPrint("d. Nej, det er kun dårlig hvis emballagen er lavede af plastik.", 20);
            Utility.SlowPrint("Vælge enten a, b, c, eller d.", 20);

            bool hasAnswered = false;

            while (!hasAnswered)
                {
                    string? answer = Console.ReadLine();
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
                            Console.WriteLine("Rigtig");
                            hasAnswered = true;
                            break;

                        case "d":
                            Console.WriteLine("Forkert");
                            hasAnswered = true;
                            break;

                        default:
                            Console.WriteLine("Dette er ikke en svar. Prøve igen.");
                            break;
                    }
                }
    }

}
