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
            Utility.SlowPrint("Det bliver derfor tydeligt, at løsningen på emballageproblemet kræver en bredere indsats,", 30);
            Utility.SlowPrint("hvor både producenter og forbrugere spiller en rolle", 30);
            Utility.SlowPrint("i at finde en balance mellem funktionalitet og bæredygtighed.", 30);
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
            Utility.SlowPrint("Krav for løsning af emballageproblemet.", 20);
            Utility.SlowPrint("For hvilke dele af emballageproblemet, spiller producenter og forbrugere en vigtig rolle, i forhold til at løse problemet?", 20);
            Utility.SlowPrint("a. Producenter og forbrugere spiller en vigtig rolle i at finder en balance mellem funktionalitet og bæredygtighed.", 20);
            Utility.SlowPrint("b. Producenter spiller en vigtig rolle kun for funktionaliteten, og bæredygtigheden er noget forbrugerene skal tage sig af.", 20);
            Utility.SlowPrint("c. Producenter og forbrugere spiller en vigtig rolle i at sørge for at produkter fortsætter med at blive produceret og brugt så meget som muligt.", 20);
            Utility.SlowPrint("d. Producenter og forbrugere spiller en vigtig rolle kun i at gøre produkter og emballage så bæredygtig som muligt.", 20);
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
