/**
 * Player class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/
public class Item
{
    private int durability = 100;
    private string[] arrayItem = new string[10];

    public Item(Resource resources)
    {
        for (int i = 0; i < arrayItem.Length; i++)
        {
            if (arrayItem[i] == null)
            {
                arrayItem[i] = CreateItem(resources);
            }
        }
    }

    string CreateItem(Resource r)
    {
        if (r == null)
        {
            return null;
        }

        if (r.name == "plastic")
        {
            return "p";
        }
        else if (r.name == "metal")
        {
            return "m";
        }
        else if (r.name == "wood")
        {
            return "w";
        }
        else if (r.name == "cardboard")
        {
            return "c";
        }
        else if (r.name == "")
        {
            return "Empty";
        }
        else
        {
            return null;
        }
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
        return amount >= durability;
    }

    public int RepairItem(int amount)
    {
        if (durability < 100)
        {
            durability += amount;
        }
        return durability;
    }

    public int DamageItem(int amount)
    {
        durability -= amount;
        return durability;
    }
    

}
