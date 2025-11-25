/* Main class for launching the game
 */

class CommandCheck : BaseCommand, ICommand
{
    private Player _player;
    private Space _space; 
    public CommandCheck(Player player)
    {
        _player = player;
        description = "- Item : Tjekker holdbarheden af et item i inventaret.\n\t - logbog : Tjekker det nuværende mål.\n\t - ressourcer : Tjekker hvilke ressourcer der er tilgængelige i inventaret.";
    }
    public void Execute(Context context, string command, string[] parameters)
    {
        _space = context.GetCurrent(); 
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("Hvad ville du gerne tjekke?");
            return;
        }
        else if (parameters[0].ToLower() == "logbook" || parameters[0].ToLower() == "logbog")
        {
            _player.logbook.DisplayCurrentObjective();
            return;
        }
        else if (parameters[0].ToLower() == "resources" || parameters[0].ToLower() == "ressourcer")
        {
            Console.Write("Tilgængelige ressourcer: ");
            _player.PrintResource();
            Console.WriteLine(" ");
            return; 
        }

        else if (parameters[0].ToLower() == "story" || parameters[0].ToLower() == "historie")
        {
            Utility.SlowPrint("Historien er som følger: ",30);
            _player.story.DisplayCurrentStory();
            return;
        }
        else if (parameters[0].ToLower() == "print" && _space.GetName() == "beach")
        {
            Beach beach = (Beach)context.GetCurrent();
            beach.PrintResources();
            return;
        }
        // Tjekker hvert item i inventaret
        for(int i = 0; i<_player.items.Count; i++)
        {
            // Tjekker om navnet på itemet matcher det spilleren leder efter
            if (_player.items[i].ToString() == parameters[0])
            {
                // Holdbarheden af itemet kan nu tjekkes
                Console.WriteLine($"{parameters[0]} er i inventaret.");
                return;
            }
        }
        // Itemet spilleren ledte efter blev ikke fundet i arrayet
        Utility.SlowPrint($"Beklager, men '{parameters[0]}' er ikke i inventaret.", 10);
    }
}
