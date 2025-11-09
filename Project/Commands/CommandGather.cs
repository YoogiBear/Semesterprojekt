
class CommandGather : BaseCommand, ICommand
{
    private Player _player;
    public CommandGather(Player player)
    {
        _player = player;
        description = "Allows for gathering resources in Ocean and near trees";

    }
    //attempts to execute GoCommand with given context, command and given parameters else return 
    public void Execute(Context context, string command, string[] parameters)
    {

        if (command == "gather")
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

        if (command == "collect")
        {
            Ocean ocean = (Ocean)context.GetCurrent();
            if (context.GetCurrent().GetName() != "the ocean")
            {
                Console.WriteLine("Seems you can't gather resources here");
                return;
            }
            else
            {

                string? wanted = parameters[0];
                //Console.WriteLine(wanted);
                Resource gathered = ocean.TakeResource(wanted);
                _player.AddResource(gathered);
                Console.Write("You have garthered: ");
                _player.PrintResource();
                Console.WriteLine();
                Console.WriteLine("You have collected 1 " + parameters[0]);
            }
        }
    }
}