/**
 * Player class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Player
{
    public string[] resources;
    public string[] items;
    public string[] food;
    public string[] objectives;

    public Player()
    {
        resources = new string[10];
        items = new string[10];
        food = new string[10];
        objectives = new string[10];
    }

    public void Build() { throw new NotImplementedException(); }
    public void Consume() { throw new NotImplementedException(); }
    public void Catch() { throw new NotImplementedException(); }
    public void Repair() { throw new NotImplementedException(); }
}
