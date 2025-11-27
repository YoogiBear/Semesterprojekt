using System.Reflection.Metadata.Ecma335;

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
            Console.Write(r.Name + " ");
        }

        
    }

    public int Build(List<Resource> listResource)
    {
        int boatDurability = 0;
        foreach (Resource resource in listResource)
        {
            if (resource != null) continue;
            
            boatDurability += resource.Strength;
        }

            if (boatDurability < 150)
            {
                while (true)
                {
                    Console.WriteLine(
                        "Der er desværre ikke nok materialer til at bygge hele båden, vil du gerne bruge dine nuværende materialer til at bygge med?");
                    Console.WriteLine("Ja/Nej ?");
                    string? input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Ikke gyldigt input");
                        continue;
                    }

                    string answer = input.ToLower();
                    if (answer == "ja")
                    {
                        listResource.Clear();
                        break;
                    }
                    else if (input == "nej")
                    {
                        boatDurability = 0;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Jeg forstod ikke dit svar, prøv igen");
                    }
                }
            }
        return boatDurability;
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
