using System.Reflection.Metadata;

public class Item
{
    //Sætter holdbarhed til 100
    private int durability = 100;
    //En tom streng til at sætte vores Item ind i
    private string itemCode;

    //Konstruktor for Item, kalder CreateItem, hvis ressourcen er null, kaster den en undtagelse
    public Item(Resource resources)
    {
        if (resources == null)
        {
            throw new ArgumentNullException(nameof(resources));
        }

        itemCode = CreateItem(resources);
    }
    
    //Tjekker resource-parameteren, og hvis navnet på ressourcen matcher et item, bliver det oprettet
    string CreateItem(Resource r)
    {
        
        if (r == null) { return null;}

        switch (r.Name)
        {
            case "plast":
                return "Spade";
            case "metal":
                return "Fiskestang";
            case "Wood":
                return "Planke";
            case "cardboard":
                return "Kasse";
            case "":
                return "tom";
            default:
                return null;
        }
    }
    
    //Ikke implementeret endnu
    public string Interaction(Player player)
    {
        throw new NotImplementedException();

    }
    
    //Ikke implementeret endnu
    public string Placed(Player player)
    {
        throw new NotImplementedException();

    }
    
    //Hvis mængden er større eller lig med holdbarheden, returnerer den true, ellers false
    public bool DestroyItem(int amount)
    {
        return amount >= durability;
    }
    
    //Reparerer item med den indtastede mængde. Holder holdbarhed på maksimalt 100, selv hvis reparationen går fra 80 til 130
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
    
    //Skader item med den indtastede mængde. Tjekker at holdbarheden ikke går under 0
    public int DamageItem(int amount)
    {
        if (amount < 0) //Undgår negativ mængde, der ville øge holdbarheden
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
    
    //Lavede en ToString, så vi kan printe listen af items spilleren har
    public override string ToString() 
    {
        return itemCode;
    }

}

public class Boat : Item {

    public Boat(Resource resource) : base(resource)
    {

    }
}
