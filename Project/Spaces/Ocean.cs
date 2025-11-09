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
    public Ocean(string Name) : base(Name)
    {
        resources = new Resource[10];
        food = new List<Food>() { new Food(), new Food()};
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

    public override void Welcome()
    {
        if (hasVisited == false)
        {
            Utility.SlowPrint("A lot of plastic ends up as microplastics in nature, and due to its strength, it takes an extremely long time to decompose.", 20);
            Utility.SlowPrint("11 million tons of plastic waste finds its way to our oceans, through mis-sorting and dumping of waste in the ocean. These 11 million tons,", 20);
            Utility.SlowPrint("are just a small addition to the already 200 million tons that are already in the world's oceans. With this rate of production and waste, there will be more plastic than fish in the sea by 2050.", 30);
            hasVisited = true;
        }
        else
        {
            Utility.SlowPrint("You return to the ocean. The water feels familiar.", 30);
        }

        ShowStatus();
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Pollution Level: {Pollution.Level}");
        Console.WriteLine("Food sources: " + (food.Count == 0 ? "(none)" : string.Join(", ", food)));
    }

}



// Food generator component
public static class FoodGenerator
{
    public static readonly List<string> foodSources = new List<string>();
    public static IReadOnlyList<string> FoodSources => foodSources.AsReadOnly();
    
    public static void GenerateFish()
    {
        if (Island.pollution <= 10) //Little to no pollution
        {
            for (int i = 0; i < 4; i++)
            {
                foodSources.Add("Fish");
                Console.WriteLine(i);
            }
            Console.WriteLine($"Fish generated succesfully overnight!.");
            return;
        }
        else if (10 < Island.pollution && Island.pollution <= 20) //Slight pollution
        {
            for (int i = 0; i < 3; i++)
            {
                foodSources.Add("Fish");
            }
            Console.WriteLine($"Fish generated succesfully overnight!.");
            return;
        }
        else if (20 < Island.pollution &&    Island.pollution <= 30) //Average pollution
        {
            for (int i = 0; i < 2; i++)
            {
                foodSources.Add("Fish");
            }
            Console.WriteLine($"Fish generated succesfully overnight!.");
            return;
        }
        else if (30 < Island.pollution && Island.pollution <= 40) //Max pollution
        {
            foodSources.Add("Fish");
            Console.WriteLine($"Fish generated succesfully overnight!.");
            return;
        }
        else if (40<Island.pollution ) //Dead fish
        {
            Console.WriteLine("Too much pollution in the ocean! No fish were generated overnight.");
            return;
        }

    }
}

