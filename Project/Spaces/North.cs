/*
Look center class for code explantion
*/

public class North : Space
{
    public North(String name) : base(name)
    {
        
    }
    public static bool hasVisitedNorth;

    public override void Welcome()
    {
        if (hasVisitedNorth == false)
        {
            Utility.SlowPrint($"Dette er første gang, du besøger {name}. Du finder en avis og begynder at læse den.", 20);
            Utility.SlowPrint("MÆNGDEN AF SKRALD I VERDENSHAVENE TAGER OVERHÅND", 30);
            Utility.SlowPrint("Mere end hver tredje fisk fanget til mennesker indeholder nu skrald", 30);
            Utility.SlowPrint("80% af det studerede skrald er plastik...", 30);
            hasVisitedNorth = true;
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



    public static void QuestionNorth()
    {
        if (hasVisitedNorth == true)
        {
            Utility.SlowPrint("Livet i havet", 20);
            Utility.SlowPrint("Hvor stor en procentdel af fisk, der fanges til mennesker, indeholder plastik", 20);
            Utility.SlowPrint("A: Alle", 20);
            Utility.SlowPrint("B: Omkring 20%", 20);
            Utility.SlowPrint("C: Omkring 50%", 20);
            Utility.SlowPrint("D: Over 33%", 20); //Source: https://www.sas.org.uk/plastic-pollution/plastic-pollution-facts-figures/
            Utility.SlowPrint("Vælg enten A, B, C eller D.", 20);

            bool hasAnswered = false;
            while (!hasAnswered)
                {
                    string? answer = Console.ReadLine().ToLower();
                    switch(answer)
                    {
                        case "a":
                            Console.WriteLine("Forkert!");
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
