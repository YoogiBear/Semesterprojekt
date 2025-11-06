
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
            
        }
    }
}