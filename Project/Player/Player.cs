/**
 * Player class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Player
{
    public List<Resource> resources;
    public List<Item> items;
    public List<Food> foods;
    public int hunger = 0;
    public const int maxHunger = 100;
    public string[] objectives;
    public Logbook logbook;
    public Story story;
    public Player()
    {
        resources = new List<Resource>();
        items = new List<Item>();
        foods = new List<Food>();
        objectives = new string[10];
        logbook = new Logbook();
        story = new Story();
    }
    
    //Adds a resource to players list
    public void AddResource(Resource resource)
    {
        if (resource == null) return;
        resources.Add(resource);
    }
    
    //Prints resources out that are available in the player inventory  
    public void PrintResource()
    {
        foreach (Resource r in resources)
        {
            Console.Write(r.name + " ");
        }

        
    }

    public string Build(List<Resource> lR)
    {
        int countP = lR.Count(r => r.name == "plastic");
        int countW = lR.Count(r => r.name == "wood");
        int countM = lR.Count(r => r.name == "metal");
        int countC = lR.Count(r => r.name == "cardboard");
        
        List<string> missingR = new List<string>();

        if (countP < 5)
        {
            missingR.Add($"Mangler {5-countP} plastik");
        }

        if (countW < 10)
        {
            missingR.Add($"Mangler {10-countW} træ");
        }

        if (countM < 3)
        {
            missingR.Add($"Mangler {3-countM} metal");
        }

        if (countC < 20)
        {
            missingR.Add($"Mangler {20-countC} pap");
        }

        if (missingR.Count == 0)
        {
            return "boat";
        }
        
        return string.Join(", ", missingR);

        
    }
    public void Catch(Food food) { foods.Add(food); }

    public void Repair()
    {
        foreach (Item i in items)
        {
            i.RepairItem(5);
        }
    }

    public int Hunger()
    {
        return hunger;
    }

    public void Eat(int decrease) {
        hunger -= decrease;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }

    public bool IsPlayerDeadFromHunger() { return hunger >= 100; }
    
}
