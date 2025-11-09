/**
 * Ocean class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Ocean : Space
{
    public bool hasVisited;
    public Resource[] resourcesprefab =
        [
            new Resource("plastic"), new Resource("plastic"),
            new Resource("metal"), new Resource("metal"),
            new Resource("plastic"), new Resource("plastic"),
            new Resource("plastic"), new Resource("plastic"),
            new Resource("plastic"),new Resource("plastic")
        ];

    public Resource[] resources; //Array to hold resources within the ocean
    public List<Food> food; //List to hold food sources within the ocean
    public int pollutionLevel;
    public Ocean(string Name) : base(Name)
    {
        resources = new Resource[10];
        food = new List<Food>() { new Food(), new Food()};
        pollutionLevel = 10;
        
        CreateResources();
    }
    
    //Changed so CreateResources now copies the elements of resourcesprefab and not just hold the same values
    public void CreateResources()
    {
        resources = new Resource[resourcesprefab.Length];

        for (int i = 0; i < resourcesprefab.Length; i++)
        {
            resources[i] = resourcesprefab[i];
        }
    }

    public Resource TakeResource(string r) //Removes resource from ocean when called
    {
        if (string.IsNullOrWhiteSpace(r))
        {
            return null;
        }

        for(int i = 0; i < resources.Length; i++)
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
            Utility.SlowPrint("A lot of plastic ends up as microplastics in nature, and due to its strength, it takes an extremely long time to decompose.", 30);
            Utility.SlowPrint("11 million tons of plastic waste find their way into our oceans through incorrect sorting and waste dumping at sea. These 11 million tons", 30);
            Utility.SlowPrint("are just a small addition to the already 200 million tons that are already in the worlds oceans. At this rate of production and waste, there will be more plastic than fish in the ocean by 2050.", 30);
            hasVisited = true;
            Utility.SlowPrint("You can see these paths:", 20);
            HashSet<string> exits = edges.Keys.ToHashSet();
            foreach (String exit in exits)
            {
                Console.WriteLine(" - " + exit);
                Thread.Sleep(500);
            }
            Utility.SlowPrint("What would you like to do now?", 20);
        }
        else
        {
            Utility.SlowPrint("You are back in the forest, chop down trees or collect some fruits", 30);
            Utility.SlowPrint("You can see these paths:", 20);
            HashSet<string> exits = edges.Keys.ToHashSet();
            foreach (String exit in exits)
            {
                Console.WriteLine(" - " + exit);
                Thread.Sleep(500);
            }
            Utility.SlowPrint("What would you like to do now?", 20);
        }
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Pollution Level: {Pollution.Level}");
        Console.WriteLine("Food sources: " + (food.Count == 0 ? "(none)" : string.Join(", ", food)));
    }

}



// Food generator component
public class FoodGenerator
{
    public readonly List<string> foodSources = new List<string>();
    public IReadOnlyList<string> FoodSources => foodSources.AsReadOnly();

    public void GenerateFish(int count)
    {
        if (count <= 0) return;
        for (int i = 0; i < count; i++)
        {
            foodSources.Add("Fish");
        }
        Console.WriteLine($"{count} fish generated.");
    }
}

