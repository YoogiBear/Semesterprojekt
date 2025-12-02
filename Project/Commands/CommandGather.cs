class CommandGather : BaseCommand, ICommand
{
    private Player _player;
    private Space _space;
    public CommandGather(Player player)
    {
        _player = player;
        description = "Giver mulighed for at samle ressourcer på stranden. Brug 'saml frugt'";
    }
    //Attempts to execute a command with a given context, command and parameters or returns
    public void Execute(Context context, string command, string[] parameters)
    {
        //Assigns the current context to parameter
        _space = context.GetCurrent();
        //Validates whether the parameter given is exactly 1
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("Jeg ved ikke, hvad du skal samle 🤔");
            return;
        }
        //Starts a switch on what the current space name is
        switch(_space.GetName().ToLower())
        {
            //if the current space is beach it allows for gathering of a resource
            case "beach":
                //To allow the use of beach command the current space requires a reference
                Beach beach = (Beach)context.GetCurrent();
                string wanted = parameters[0];
                Resource gathered = beach.TakeResource(wanted);
                _player.AddResource(gathered);
                return;
            //If the current area is within a forest area.
            case "the forest area":
                //Checks whether there is no valid tree target to gather fruit from, or if there is NOT any fruits to collect.
                if(Island.trees.Count == 0 || Island.trees.Exists(fruitsOntrees => fruitsOntrees.fruitsOnTree == 0)) {
                    Console.WriteLine("Der er ikke flere frugter på træet.");
                } else {
                    //Gather fruit and add to player inventory.
                    Tree? tree = Island.trees.Find(fruitsOntrees => fruitsOntrees.fruitsOnTree > 0);
                    Console.WriteLine(tree?.Gather(_player));
                }
                    return;
             //The player is not within an area with which to either collect fruits or catch fish.
            default: Console.WriteLine("Der er ikke noget at samle her"); return;
        }
    }

}
