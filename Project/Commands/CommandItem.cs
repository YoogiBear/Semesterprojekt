
class CommandItem : BaseCommand, ICommand
{
    Player player;
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
            for(int i = 0; i < player.resources.Count() ; i++)
            {

                if (player.resources[i].name == parameters[0])
                {
                    player.items.Add(new Item(player.resources[i]));
                    player.resources.Remove(player.resources[i]);
                }
                else
                {
                    Console.WriteLine("Uhm, please check what resources you have");
                }
            }

            if (parameters[0] == "print")
            {
                foreach (Item i in player.items)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}