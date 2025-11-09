public class Item
{
    //Sets Durability to 100
    private int durability = 100;
    //An empty string to put our Item into
    private string itemCode;

    //Constructor for Item, calls CreateItem, if the resource is null, it throws an exception
    public Item(Resource resources)
    {
        if (resources == null)
        {
            throw new ArgumentNullException(nameof(resources));
        }

        itemCode = CreateItem(resources);
    }
    
    //Check the resource parameter and if the name of the resource matches to an item, it gets created
    string CreateItem(Resource r)
    {
        
        if (r == null)
        {
            return null;
        }
        
        if (r.name == "plastic")
        {
            return "Spade";
        }
        else if (r.name == "metal")
        {
            return "Fishing rod";
        }
        else if (r.name == "wood")
        {
            return "Plank";
        }
        else if (r.name == "cardboard")
        {
            return "Box";
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
    
    //Not implemented yet
    public string Interaction(Player player)
    {
        throw new NotImplementedException();

    }
    
    //Not implemented yet
    public string Placed(Player player)
    {
        throw new NotImplementedException();

    }
    
    //If the amount is greater or equal to durability it will return true, if not it returns false
    public bool DestroyItem(int amount)
    {
        return amount >= durability;
    }
    
    //Repairs the item by the amount inputed. Keeps durability at a max of 100, even if repair gets it from 80 to 130
    public int RepairItem(int amount)
    {
        if (durability < 100)
        {
            durability += amount;

            if (durability > 100)
            {
                durability = 100;
            }
        }
        return durability;
    }
    
    //Damage the item by the amount inputed. Checks and make sure durability isn't 0
    public int DamageItem(int amount)
    {
        if (amount < 0) //Avoids a negative amount that would increase durability
        {
            amount = 0;
        }
        
        durability -= amount;

        if (durability <= 0)
        {
            durability = 0; 
        }
        
        return durability;
    }
    
    //Created a ToString so we can print the list of Items the player have
    public override string ToString() 
    {
        return itemCode;
    }

}
