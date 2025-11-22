/*
Look center class for code explantion
*/

public class West : Space
{
    public West(String name) : base(name)
    {

    }
    public static bool hasVisitedWest;

    public override void Welcome()
    {
        if (hasVisitedWest == false)
        {
            Utility.SlowPrint($"Dette er første gang, du besøger {name}. Du finder en avis og begynder at læse den.", 20);
            Utility.SlowPrint("Det giver et problem for os mennesker, siden forbruget af naturlige ressourcer er steget over de sidste 50 år,", 30);
            Utility.SlowPrint("og det vil blive ved med at stige globalt fremover. Udover det er vores udnyttelse af genanvendelse af det affald, der bliver produceret, ikke god nok.", 30);
            Utility.SlowPrint("Det betød, at vi i de sidste 5 måneder af 2018 overtrak mængden af Jordens ressourcer.", 30);
            Utility.SlowPrint("Forbruget svarede til 1.7 jordkloder, hvis ressourcerne skulle fornyes.", 30);
            hasVisitedWest = true;
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



    public static void QuestionWest()
    {
        if (hasVisitedWest == true)
            Utility.SlowPrint("Forbrug af ressourcer:", 20);
            Utility.SlowPrint("Hvor mange jorkloder af ressources svare forbruget til, i 2018?", 20);
            Utility.SlowPrint("a. 1.7 jordkloder.", 20);
            Utility.SlowPrint("b. 2 jordkloder.", 20);
            Utility.SlowPrint("c. 5 jordkloder.", 20);
            Utility.SlowPrint("d. 0.7 jordkloder.", 20);
            Utility.SlowPrint("Vælge enten a, b, c, eller d.", 20);

            bool hasAnswered = false;

            while (!hasAnswered)
                {
                    string? answer = Console.ReadLine();
                    switch(answer)
                    {
                        case "a":
                            Console.WriteLine("Rigtig");
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
