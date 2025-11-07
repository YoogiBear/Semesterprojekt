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
            Utility.SlowPrint($"This is the first time visiting {name}. You find a newspaper and start reading it.", 20);
            Utility.SlowPrint("In 2022, packaging made up 1,108,000 tons — equivalent to approximately 189.6 kg per citizen in Denmark.",30);
            Utility.SlowPrint(" Around 200,000 tons of that came from plastic packaging — a material that is both costly to produce and is downcycled, meaning it can eventually no longer be recycled.",30);
            hasVisited = true;
        }
        else
        {
            Console.WriteLine("You return to the ocean. The water feels familiar.");
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

