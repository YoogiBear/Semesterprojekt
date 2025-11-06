/* Main class for launching the game
 */

class CommandCheck : BaseCommand, ICommand
{
    private Player _player;
    public CommandCheck(Player player)
    {
        _player = player;
        description = "- Item : Checks durability of item in inventory.\n\t  - logbook : Checks current objective.";

    }
    public void Execute(Context context, string command, string[] parameters)
    {
        if (GuardEq(parameters, 1))
        {
            Console.WriteLine("You wanted to check what exactly?");
            return;
        }
        else if (parameters[0].ToLower() == "logbook")
        {
            _player.logbook.DisplayCurrentObjective();
            return;
        }
        //Check every item in the inventory array
        for(int i = 0; i<_player.items.Length; i++)
        {
            //Item cannot be null because null isnt type item
            if (_player.items[i] != null)
            {
                //Check to see if the name of the item is what the player is looking for
                if (_player.items[i].ToString() == parameters[0])
                {
                    //The durability of the item can now me checked
                    Console.WriteLine($"{parameters[0]} is in inventory.");
                    return;
                }
            }
        }
        //The item the player was looking for was not found the array at all.
        Utility.SlowPrint($"Sorry but '{parameters[0]}' isn't in the inventory", 10);

    }
}