/**
 * Player class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/
public class Item
{
    public int durability;
    public string[] materials;

    public Item ()
    {
        durability = 100;
        materials = new string[10];
    }

    public string[] CreateItem()
    {
        throw new NotImplementedException();

    }

    public string Interaction(Player player)
    {
        throw new NotImplementedException();

    }
    public string Placed()
    {
        throw new NotImplementedException();

    }
    public bool DestroyItem(int amount)
    {
        throw new NotImplementedException();

    }
    public int RepairItem(int amount)
    {
        throw new NotImplementedException();

    }

    public int DamageItem(int amount)
    {
        throw new NotImplementedException();

    }


}
