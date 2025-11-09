
class CommandGather : BaseCommand, ICommand
{
    private Player _player;
    public CommandGather(Player player)
    {
        _player = player;
        description = "Allows for gathering resources in Ocean";

    }
    //attempts to execute GoCommand with given context, command and given parameters else return 
    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("I don't seem to know what to gather 🤔");
            return;
        }
        else if (context.GetCurrent().GetName() != "the ocean")
        {
            Console.WriteLine("You need to be in the ocean to gather resources");
            return;
        } 
        else if (context.GetCurrent().GetName() == "the ocean")
        {
            Ocean ocean = (Ocean)context.GetCurrent();
            string? wanted = parameters[0];
            //Console.WriteLine(wanted);
            Resource gathered = ocean.TakeResource(wanted);
            _player.AddResource(gathered);
            return;
            /*Console.Write("You have garthered: ");
            _player.PrintResource();
            Console.WriteLine();
            Console.WriteLine("You have collected 1 " + parameters[0] + " ");*/
        }
    }
}