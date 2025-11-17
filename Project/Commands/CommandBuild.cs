/* Command for transitioning between allowed spaces
 */

class CommandBuild : BaseCommand, ICommand
{
    private Player _player;

    public CommandBuild(Player player)
    {
        _player = player;
        description = "Kan bruges til at bygge en båd til at komme væk fra øen.";
    }

    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("Du prøvede at bygge ingenting, og det lykkedes? 🤔");
            return;
        }

        if (parameters[0] == "boat" || parameters[0] == "båd")
        {
            Console.WriteLine(_player.Build(_player.resources));
        }
        else
        {
            Console.WriteLine("Hvad prøver du at bygge?");
        }
        // Tillader udførelse af kommando
    }
}
