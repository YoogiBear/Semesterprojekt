/**
 * Player class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Player
{
    public Resource[] resources;
    public Item[] items;
    public List<Food> foods;
    public string[] objectives;

    public Player()
    {
        resources = new Resource[10];
        items = new Item[10];
        foods = new List<Food>();
        objectives = new string[10];
    }

    public void Build() { throw new NotImplementedException(); }
    public void Consume() { throw new NotImplementedException(); }
    public void Catch(Food food) { foods.Add(food); }
    public void Repair() { throw new NotImplementedException(); }
}
