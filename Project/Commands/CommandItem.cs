
class CommandItem : BaseCommand, ICommand
{
    Player player;
    public List<Item> items = new List<Item>();
    public CommandItem(Player player)
    {
        this.player = player;
        description = "Allows for the player to create a Item matching the resources gathered";
    }

    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("Hmm, seems you want to create a Item with no resources");
            return; 
        }
        else
        {
            //Currently takes a input from the user and then checks if i matches to a resource type manually 
            //TODO: Need to implement resource gathering for the player and then this need to be changed to match for a resource the player have
            //This is made for testing and to show how it works not a final solution
            foreach (string s in parameters)
            {
                if (s == "plastic")
                {
                    Resource r = new Resource("plastic");
                    items.Add(new Item(r));
                }else if (s == "metal")
                {
                    Resource r = new Resource("metal");
                    items.Add(new Item(r));
                }else if (s == "cardboard")
                {
                    Resource r = new Resource("cardboard");
                    items.Add(new Item(r));
                }else if (s == "wood")
                {
                    Resource r = new Resource("wood");
                    items.Add(new Item(r));
                }
                else if (s == "print")
                {
                    foreach (Item i in items)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}