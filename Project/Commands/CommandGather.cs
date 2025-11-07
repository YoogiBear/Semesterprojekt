
class CommandGather : BaseCommand, ICommand
{
    private Player player;


    public CommandGather(Player player)
    {
        this.player = player;
        description = "You can use this command to gather resources";
    }

    public void Execute(Context context, string command, string[] parameters)
    {
        Ocean ocean = (Ocean)context.GetCurrent();
        if(GuardEq(parameters, 1))
        {
            Console.WriteLine("I don't seem to know what to gather here");
            return;
        }
        else if (context.GetCurrent().GetName() != "the ocean")
        {
            Console.WriteLine("Seems you can't gather resources here");
            return;
        }
        else
        {
            
            string? wanted = parameters[0];
            //Console.WriteLine(wanted);
            Resource gathered = ocean.TakeResource(wanted);
            player.AddResource(gathered);
            Console.Write("You have garthered: ");
            player.PrintResource();
            Console.WriteLine();
            Console.WriteLine("You have collected 1 " + parameters[0]);
        }
    }
}