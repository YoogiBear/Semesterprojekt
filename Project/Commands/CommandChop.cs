class CommandChop : BaseCommand, ICommand
{
    private Player _player;
    private Tree _tree;

    public CommandChop(Player player)
    {
        _player = player;
        _tree = Island.trees[0];
        description = "Allows for chopping trees for resources. But only near a tree..";
    }

    public void Execute(Context context, string command, string[] parameters)
    {
        // Hvis spilleren skriver kun "chop"
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("I don't seem to know what to chop 🤔");
            return;
        }

        // Spilleren skal være i skov-området
        if (context.GetCurrent().GetName() != "the forest area")
        {
            Console.WriteLine("You are not within an area for which to chop anything.");
            return;
        }

        if (Island.trees.Count == 0)
        {
            Console.WriteLine("There are no trees left to chop.");
            return;
        }

        // Udfører den eksisterende Tree-metode (du behøver ikke ændre noget i Tree)
        Tree tree = Island.trees[0];
        string result = tree.ChopTree(_player);
        Console.WriteLine(result);
       
    }
}
