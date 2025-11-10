
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
        }
        else
        {
            //Checks if the player have a resources that matches the input and then creates the Item while removing the resources from the player
            for(int i = 0; i < player.resources.Count() ; i++)
            {

                if (player.resources[i].name == parameters[0].ToLower())
                {
                    player.items.Add(new Item(player.resources[i]));
                    player.resources.Remove(player.resources[i]);
                }
                else
                {
                    Console.WriteLine("Uhm, please check what resources you have");
                }
            }

            if (parameters[0].ToLower() == "print")
            {
                foreach (Item i in player.items)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}