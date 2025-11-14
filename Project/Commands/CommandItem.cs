class CommandItem : BaseCommand, ICommand
{
    Player player;
    public CommandItem(Player player)
    {
        this.player = player;
        description = "Giver spilleren mulighed for at oprette et item, der matcher de indsamlede ressourcer";
    }
    
    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("Hmm, det ser ud til, at du vil oprette et item uden ressourcer");
        }
        else
        {
            //Tjekker om spilleren har en ressource, der matcher input, og opretter itemet, mens ressourcen fjernes fra spilleren
            for(int i = 0; i < player.resources.Count() ; i++)
            {

                if (player.resources[i].name == parameters[0].ToLower())
                {
                    player.items.Add(new Item(player.resources[i]));
                    player.resources.Remove(player.resources[i]);
                }
                else
                {
                    Console.WriteLine("Øhm, tjek venligst hvilke ressourcer du har");
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
