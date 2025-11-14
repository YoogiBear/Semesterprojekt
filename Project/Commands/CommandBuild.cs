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
            Console.WriteLine("Du prøvede at bygge ingenting, og det lykkedes? 🤔");
            return;
        }
        // Tillader udførelse af kommando
    }
}
