/**
 * Player class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Player
{
    public List<Resource> resources;
    public string[] items;
    public List<Food> foods;
    public string[] objectives;

    public Player()
    {
        resources = new List<Resource>();
        items = new string[10];
        foods = new List<Food>();
        objectives = new string[10];
    }

    public void Build() { throw new NotImplementedException(); }
    public void Consume() { throw new NotImplementedException(); }
    public void Catch() { throw new NotImplementedException(); }
    public void Repair() { throw new NotImplementedException(); }
}
