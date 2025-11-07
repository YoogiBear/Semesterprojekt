class CommandGather : BaseCommand, ICommand
{
    private Player _player;
    public CommandGather(Player player)
    {
        _player = player;
        description = "Allows for gathering fruits. But only near a tree.";

    }
    //attempts to execute GoCommand with given context, command and given parameters else return 
    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("I don't seem to know what to gather 🤔");
            return;
        }
        else if (context.GetCurrent().GetName() != "the forest area")
        {
            Console.WriteLine("You are not within an area for which to gather anything.");
            return;
        }
        
        if (Island.trees.Count == 0)
        {
            Console.WriteLine("There are no trees left to gather from.");
            return;
        }
        
        Tree tree = Island.trees[0]; 
        string result = tree.Gather(_player);
        Console.WriteLine(result);

    }
}