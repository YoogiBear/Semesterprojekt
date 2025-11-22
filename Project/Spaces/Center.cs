/*
Center class is only for the hasVisited at the start for the story line
*/

public class Center : Space
{
    public Center(String name) : base(name)
    {


    }
    //hasVisited bool set to false, meaning the player hasn't been in this area of the map yet.

    public static bool hasVisitedCenter;

    public override void Welcome()
    {
        if (hasVisitedCenter == false) //If the player hasn't been here before it plays the custom message.
        {
            Utility.SlowPrint($"Dette er første gang, du besøger {name}. Du finder en avis og begynder at læse den.", 20);
            Utility.SlowPrint("I 2022 udgjorde emballage 1.108.000 tons — svarende til cirka 189,6 kg pr. borger i Danmark.", 30);
            Utility.SlowPrint("Omkring 200.000 tons af dette kom fra plastikemballage — et materiale, der både er dyrt at producere og bliver downcyclet, hvilket betyder, at det til sidst ikke længere kan genanvendes.", 30);
            hasVisitedCenter = true; //Sets hasVisited to true, meaning the player won't get the custom message anymore
            Utility.SlowPrint("Du kan se disse stier:", 20);
            // Hashset is used to check the edges for which paths are open from this area

            HashSet<string> exits = edges.Keys.ToHashSet();
            foreach (String exit in exits)
            {
                Console.WriteLine(" - " + exit);
                Thread.Sleep(500);
            }
            Utility.SlowPrint("Hvad vil du gerne gøre nu?", 20);
        }

        else //If the player has been here and hasVisited is true, this will be displayed from now on when the player enters this area

        {
            Utility.SlowPrint("Du er tilbage i centrum, du kan gå i enhver retning på øen herfra.", 30);
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
    public static void QuestionCenter()
    {
        if (hasVisitedCenter == true)
        {
            Utility.SlowPrint("Plastikemballage:", 20);
            Utility.SlowPrint("Kan Plastikemballage altid genanvendes?", 20);
            Utility.SlowPrint("a. Nej, umulig.", 20);
            Utility.SlowPrint("b. Til sidst efter den bliver downcycleret kan den ikke genanvendes.", 20);
            Utility.SlowPrint("c. Ja, altid.", 20);
            Utility.SlowPrint("d. Ja, men kun hvis produktet er økologisk.", 20);
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
                            Console.WriteLine("Rigtig");
                            hasAnswered = true;
                            break;

                        case "c":
                            Console.WriteLine("Forkert");
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
}
