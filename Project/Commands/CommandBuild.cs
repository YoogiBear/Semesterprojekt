/* Command for transitioning between allowed spaces
 */

class CommandBuild : BaseCommand, ICommand
{
    private Player _player;

    public CommandBuild(Player player)
    {
        _player = player;
    }

    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("You tried to build nothing, and you succeeded? 🤔");
            return;
        }
        //Allows for command execution

    }
}