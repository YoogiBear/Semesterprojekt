/**
 * Ocean class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Ocean : Space
{
    public bool hasVisited;
    public Resource[] resourcesprefab =
        [
            new Resource(), new Resource(),
            new Resource(), new Resource(),
            new Resource(), new Resource(),
            new Resource(), new Resource(),
            new Resource(),new Resource()
        ];

    public Resource[] resources;
    public List<Food> food;
    public int pollutionLevel;
    public Ocean(string Name) : base(Name)
    {
        resources = new Resource[10];
        food = new List<Food>() { new Food(), new Food()};
        pollutionLevel = 10;
    }

    public void CreateResources()
    {
        resources = resourcesprefab;
    }

    // Add Trash object to increases pollution 
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
            Utility.SlowPrint("Meget plastik ender som mikroplast i naturen, og netop pga. dens styrke, tager det ekstremt lang tid at nedbryde det.",20);
            Utility.SlowPrint("11 million tons plastikaffald finder vej til vores have, gennem fejlsortering, og affaldsdumpning i havet. Disse 11 million tons,",20);
            Utility.SlowPrint("er blot en lille tilføjelse til de allere 200 millioner ton der allerede er i verdenshavne. Med denne rate af produktion og spilde, vil der være mere plastik end fisk i havet inden 2050.",30);
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

