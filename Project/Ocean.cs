/**
 * Ocean class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Ocean : Space
{

    public Resource[] resourcesprefab =
        [
            new Resource("plastic"), new Resource("plastic"),
            new Resource("metal"), new Resource("metal"),
            new Resource("plastic"), new Resource("plastic"),
            new Resource("plastic"), new Resource("plastic"),
            new Resource("plastic"),new Resource("plastic")
        ];

    public Resource[] resources;
    public List<Food> food;
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

    public Resource TakeResource(string r)
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

    // Add Trash object to increases pollution 
    public void AddTrash(int trash)
    {
        if (trash == 0) throw new ArgumentNullException(nameof(trash));
        int added = trash;
        Pollution.AddPollution(added);
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

