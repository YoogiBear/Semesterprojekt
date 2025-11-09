// Command for sleeping
//Restores fish based on pollution, new materials, regulates 

class CommandSleep : BaseCommand, ICommand
{
    public Player _player;
    public Ocean _ocean;
    public CommandSleep(Player player, Ocean ocean)
    {
        _player = player;
        _ocean = ocean;
        description = "Sleep to replenish ocean's resources and trash";
    }
    public void Execute(Context context, string command, string[] parameters)
    {
        if (parameters != null)
        {
            Console.Clear();
             Utility.SlowPrint("You went to sleep and wake up the next day.", 40);
            //Update player hunger
            _player.hunger -= 15;
            Thread.Sleep(1000);
            Console.WriteLine("Hunger increased by 15! Maybe some breakfast?", 10);
            //Update fish in ocean based on pollution
            Thread.Sleep(1000);
            FoodGenerator.GenerateFish();
            //Create new resources in ocean
            _ocean.CreateResources();
            Thread.Sleep(1000);
            Console.WriteLine("New materials flushed to shore", 10);
            return;
        }
    }
}