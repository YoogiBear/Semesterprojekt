/**
 * Player class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Player
{
    public List<Resource> resources;
    public List<Item> items;
    public List<Food> foods;
    public string[] objectives;

    public Player()
    {
        resources = new List<Resource>();
        items = new List<Item>();
        foods = new List<Food>();
        objectives = new string[10];
    }

    public void AddResource(Resource resource)
    {
        if (resource == null) return;
        resources.Add(resource);
    }

    public void PrintResource()
    {
        foreach (Resource r in resources)
        {
            Console.Write(r.name);
        }

        
    }

    public void Build() { throw new NotImplementedException(); }
    public void Consume() { throw new NotImplementedException(); }
    public void Catch(Food food) { foods.Add(food); }
    public void Repair() { throw new NotImplementedException(); }
    
}
