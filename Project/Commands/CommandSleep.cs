// Command for sleeping
// Restores fish based on pollution, new materials, regulates 

class CommandSleep : BaseCommand, ICommand
{
    private Player _player;
    private Ocean _ocean;
    private Island _island;
    private Beach _beach;
    public CommandSleep(Player player, Ocean ocean, Island island,  Beach beach)
    {
        _player = player;
        _ocean = ocean;
        _island = island;
        _beach = beach;
        description = "Sov for at genoprette havets ressourcer og affald";
    }
    public void Execute(Context context, string command, string[] parameters)
    {
        if (parameters != null)
        {
            Console.Clear();
            //Opdater spillerens sult
            if (_player.hunger + 25 >= 100)
            {
                _player.hunger = 100;
            } else {
                _player.hunger += 25;    
            }
            
            Utility.DrawStatusBar(_player.hunger, Player.maxHunger, "Sult", ConsoleColor.Red);
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
            Console.WriteLine("Sulten steg med 25!");

            //Lav pollution
            _island.GeneratePollution(_ocean.resources);

            //Opdater fisk i havet baseret på forurening
            Thread.Sleep(1000);
            FoodGenerator.GenerateFish(_ocean.food);
            
            //Opret nye ressourcer i havet
            _ocean.CreateResources();
            Thread.Sleep(1000);
            Console.WriteLine("Nye materialer skyllede op på stranden");
            foreach (Resource rs in _ocean.resources)
            {
                _beach.resourcePool.Add(rs);
            }

            Utility.SlowPrint("Du gik i seng og vågnede næste dag.", 40);

            //Questions
            var rand = new Random();
            bool questionIsAsked = false;
            Console.WriteLine("\nQuiz tid!");

            while(!questionIsAsked)
                {
                switch(rand.Next(1, 8))
                    {
                    case 1:
                        questionIsAsked = Center.QuestionCenter();
                        break;
                    case 2:
                        questionIsAsked = East.QuestionEast();
                        break;
                    case 3:
                        questionIsAsked = Forest.QuestionForest();
                        break;
                    case 4:
                        questionIsAsked = North.QuestionNorth();
                        break;
                    case 5:
                        questionIsAsked = Ocean.QuestionOcean();
                        break;
                    case 6:
                        questionIsAsked = South.QuestionSouth();
                        break;
                    case 7:
                        questionIsAsked = West.QuestionWest();
                        break;
                    }
                }
            
        }
    }
}











