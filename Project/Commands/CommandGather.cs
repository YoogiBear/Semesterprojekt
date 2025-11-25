class CommandGather : BaseCommand, ICommand
{
    private Player _player;
    private Space _space;
    public CommandGather(Player player)
    {
        _player = player;
        description = "Giver mulighed for at samle ressourcer på stranden. Brug 'saml frugt'";
    }

    // forsøger at udføre kommandoen med givet context, command og parametre, ellers returner
    public void Execute(Context context, string command, string[] parameters)
    {
        _space = context.GetCurrent();
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("Jeg ved ikke, hvad du skal samle 🤔");
            return;
        }
        switch(_space.GetName().ToLower())
        {
            case "beach":
                Beach beach = (Beach)context.GetCurrent();
                string wanted = parameters[0];
                Resource gathered = beach.TakeResource(wanted);
                _player.AddResource(gathered);
                return;
            case "the forest area":
                
                if(Island.trees.Count == 0 || Island.trees.Exists(fruitsOntrees => fruitsOntrees.fruitsOnTree == 0)) {
                    Console.WriteLine("Der er ikke flere frugter på træet.");
                } else {
                    Tree? tree = Island.trees.Find(fruitsOntrees => fruitsOntrees.fruitsOnTree > 0);
                    Console.WriteLine(tree?.Gather(_player));
                }
                    return;
            default: Console.WriteLine("Der er ikke noget at samle her"); return;
        }
    }

}
