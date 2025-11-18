// Command for sleeping
// Restores fish based on pollution, new materials, regulates 

class CommandSleep : BaseCommand, ICommand
{
    public Player _player;
    public Ocean _ocean;
    public Island _island;
    public CommandSleep(Player player, Ocean ocean, Island island)
    {
        _player = player;
        _ocean = ocean;
        _island = island;
        description = "Sov for at genoprette havets ressourcer og affald";
    }
    public void Execute(Context context, string command, string[] parameters)
    {
        if (parameters != null)
        {
            Console.Clear();
            //Opdater spillerens sult
            _player.hunger += 25;
            Utility.DrawStatusBar(_player.hunger, Player.maxHunger, "Sult", ConsoleColor.Red);
            Utility.SlowPrint("Du gik i seng og vågnede næste dag.", 40);
            Game.daycounter = Game.daycounter+1;
            if (_player.IsPlayerDeadFromHunger())
            {
                Utility.SlowPrint("Åh nej! Det ser ud til, at du ikke spiste og døde af sult! Øv..", 10);
                context.MakeDone();
                return;
            }
            if(Game.daycounter >7)
            {
                Utility.SlowPrint("Åh nej! Du spildte så meget tid, at du endte med at dø..\nØv!", 10);
                context.MakeDone();
                return;
            }
            Thread.Sleep(1000);
            Console.WriteLine("Sulten steg med 15! Måske lidt morgenmad?", 10);

            //Lav pollution
            _island.GeneratePollution(_ocean.resources);

            //Opdater fisk i havet baseret på forurening
            Thread.Sleep(1000);
            FoodGenerator.GenerateFish();
            

            //Opret nye ressourcer i havet
            _ocean.CreateResources();
            Thread.Sleep(1000);
            Console.WriteLine("Nye materialer skyllet op på stranden", 10);
            return;
        }
    }
}
