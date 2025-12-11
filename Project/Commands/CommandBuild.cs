/* Command for transitioning between allowed spaces
 */

class CommandBuild : BaseCommand, ICommand
{
    private Player _player;

    public CommandBuild(Player player)
    {
        _player = player;
        description = "Kan bruges til at bygge en båd for at undslippe fra øen.";
    }

    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("Du prøvede at bygge ingenting, og det lykkedes?");
            return;
        }

        if (parameters[0].ToLower() == "boat" || parameters[0].ToLower() == "båd")
        {
            if (_player.Build(_player.resources) == 150)
            {
                context.MakeDone();
            }
        }
        else
        {
            Console.WriteLine("Hvad prøver du at bygge?");
        }
        // Tillader udførelse af kommando
    }
}
