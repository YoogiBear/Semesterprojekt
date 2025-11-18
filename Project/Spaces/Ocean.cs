/**
 * Ocean class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Ocean : Space
{
    private bool hasVisited;
    private Resource[] resourcesprefab =
        [
            new Resource("plast"), new Resource("plast"),
            new Resource("metal"), new Resource("metal"),
            new Resource("plast"), new Resource("plast"),
            new Resource("plast"), new Resource("plast"),
            new Resource("plast"), new Resource("plast")
        ];

    //private Resource[] resources; //Array to hold resources within the ocean
    public List<Resource> resources = new List<Resource>();
    public List<Food> food; //List to hold food sources within the ocean
    public Ocean(string Name) : base(Name)
    {
        resources = new List<Resource>();
        food = new List<Food>() { new Food(), new Food()};
        CreateResources();
    }
    
    //Changed so CreateResources now copies the elements of resourcesprefab and not just hold the same values
    public void CreateResources()
    {
        for (int i = 0; i < resourcesprefab.Length; i++)
        {
            resources.Add(resourcesprefab[i]);
        }
    }

    public Resource? TakeResource(string r) //Removes resource from ocean when called
    {
        if (string.IsNullOrWhiteSpace(r))
        {
            return null;
        }

        for(int i = 0; i < resources.Count; i++)
        {
            Resource rs = resources[i];
            
            if (rs == null) { continue; }
            
            if (rs.name == r)
            {
                resources[i] = null;
                
                return rs;
            }
        }
        return null;
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
        if (hasVisited == false)
        {
            Utility.SlowPrint("Meget plastik ender som mikroplast i naturen, og på grund af dets styrke tager det ekstremt lang tid at nedbryde.", 20);
            Utility.SlowPrint("11 millioner tons plastaffald finder vej til vores oceaner gennem fejlsortering og dumpning af affald i havet. Disse 11 millioner tons,", 20);
            Utility.SlowPrint("er kun et lille tilskud til de allerede 200 millioner tons, der allerede findes i verdens oceaner. Med denne produktion og affaldsrate vil der i 2050 være mere plastik end fisk i havet.", 30);
            hasVisited = true;
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
