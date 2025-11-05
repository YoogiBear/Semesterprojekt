/* Help command
 */

class CommandHelp : BaseCommand, ICommand {
  Registry registry;
  
  public CommandHelp (Registry registry) {
    this.registry = registry;
    this.description = "Displays this help menu.";
  }
  
  public void Execute (Context context, string command, string[] parameters) {
    string[] commandNames = registry.GetCommandNames();
    
    // find max length of command name
    int max = 0;
    foreach (String commandName in commandNames) {
      int length = commandName.Length;
      if (length>max) max = length;
    }

        // present list of commands
        Console.WriteLine();
        Utility.SlowPrint("You flip to the last page of your logbook.", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("It reads:", 20);
        Console.WriteLine();
        Utility.SlowPrint("Commands:", 20);
        foreach (String commandName in commandNames) {
      string description = registry.GetCommand(commandName).GetDescription();
      Thread.Sleep(750);
      Console.WriteLine(" - {0,-"+max+"} "+description, commandName);
    }
        Thread.Sleep(1000);
        Console.WriteLine();
        Utility.SlowPrint("Hope it help!", 20);
        Thread.Sleep(1000);
        Console.WriteLine();
        Utility.SlowPrint("What now?", 20);

    }
}
