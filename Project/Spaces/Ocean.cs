/**
 * Ocean class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Ocean : Space
{
    public static bool hasVisitedOcean;
    private Resource[] resourcesprefab =
        [
            new Resource("metal", 4, 10),
            new Resource("pap", 5, 15),
            new Resource("træ", 7, 20),
            new Resource("glas", 5, 10),
            new Resource("bioplast", 3, 10),
            new Resource("plast", 10, 30)
        ];
    Random rand = new Random();

    //private Resource[] resources; //Array to hold resources within the ocean
    public List<Resource> resources = new List<Resource>();
    public List<Food> food; //List to hold food sources within the ocean
    public Ocean(string Name) : base(Name)
    {
        resources = new List<Resource>();
        food = new List<Food>() { new Food("fisk"), new Food("fisk")};
    }
    
    //Changed so CreateResources now copies the elements of resourcesprefab and not just hold the same values
    public void CreateResources()
    {
        
        for (int j = 0; j < 6; j++)
        {
            int spawnRate = rand.Next(90);
            
            for (int i = 0; i < resourcesprefab.Length; i++)
            {
                int resourceWeight = resourcesprefab[i].Weight;
                
                spawnRate -= resourceWeight;
                
                if (spawnRate <= 0)
                {
                    resources.Add(resourcesprefab[i]);
                    break;
                }
            }
        }
    }
    
    // Add Trash object to increase pollution 
    public void AddTrash(int trash)
    {
        if (trash == 0) throw new ArgumentNullException(nameof(trash));
        int added = trash;
        Pollution.AddPollution(added);
    }

    //Look center class for code explantion
    public override void Welcome()
    {
        if (hasVisitedOcean == false)
        {
            Utility.SlowPrint("Meget plastik ender som mikroplast i naturen, og på grund af dets styrke tager det ekstremt lang tid at nedbryde.", 20);
            Utility.SlowPrint("11 millioner tons plastaffald finder vej til vores oceaner gennem fejlsortering og dumpning af affald i havet. Disse 11 millioner tons,", 20);
            Utility.SlowPrint("er kun et lille tilskud til de allerede 200 millioner tons, der allerede findes i verdens oceaner. Med denne produktion og affaldsrate vil der i 2050 være mere plastik end fisk i havet.", 30);
            hasVisitedOcean = true;
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
            Utility.SlowPrint("Du er tilbage i havet, saml ressourcer eller fisk.", 30);
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

    public void ShowStatus()
    {
        Console.WriteLine($"Forureningsniveau: {Pollution.Level}");
        Console.WriteLine("Fødevarer: " + (food.Count == 0 ? "(ingen)" : string.Join(", ", food)));
    }



    public static void QuestionOcean()
    {
        if (hasVisitedOcean == true)
        {
            Utility.SlowPrint("Plastikaffald i havet", 20);
            Utility.SlowPrint("Hvor meget plastikaffald finder vej til vores verdenshave hvert år?", 20);
            Utility.SlowPrint("a: Intet.", 20);
            Utility.SlowPrint("b: Ca. 11 mio. tons.", 20);
            Utility.SlowPrint("c: Ca. 10.000 tons.", 20);
            Utility.SlowPrint("d: Ca. 5 tons.", 20);
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
                            Console.WriteLine("Korrekt!");
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
                            Console.WriteLine("Dette er ikke et svar. Prøv igen.");
                            break;
                    }
                }
        }
    }
}



// Food generator component
public static class FoodGenerator
{
    private static readonly List<string> foodSources = new List<string>();
    public static IReadOnlyList<string> FoodSources => foodSources.AsReadOnly();
    
    public static void GenerateFish()
    {
        if (Island.pollution <= 10) //Little to no pollution
        {
            for (int i = 0; i < 4; i++)
            {
                foodSources.Add("Fisk");
            }
            Console.WriteLine($"Fisk genereret succesfuldt natten over.");
            return;
        }
        else if (10 < Island.pollution && Island.pollution <= 20) //Slight pollution
        {
            for (int i = 0; i < 3; i++)
            {
                foodSources.Add("Fisk");
            }
            Console.WriteLine($"Fisk genereret succesfuldt natten over.");
            return;
        }
        else if (20 < Island.pollution && Island.pollution <= 30) //Average pollution
        {
            for (int i = 0; i < 2; i++)
            {
                foodSources.Add("Fisk");
            }
            Console.WriteLine($"Fisk genereret succesfuldt natten over!.");
            return;
        }
        else if (30 < Island.pollution && Island.pollution <= 40) //Max pollution
        {
            foodSources.Add("Fisk");
            Console.WriteLine($"Fisk genereret succesfuldt natten over!.");
            return;
        }
        else if (40<Island.pollution ) //Dead fish
        {
            Console.WriteLine("For meget forurening i havet! Ingen fisk blev genereret natten over.");
            return;
        }

    }
}
