/* Help command
 */

class CommandHelp : BaseCommand, ICommand {
  Registry registry;
  
  public CommandHelp (Registry registry) {
    this.registry = registry;
    this.description = "Viser denne hjælpe-menu.";
  }
  
  public void Execute (Context context, string command, string[] parameters) {
    if (parameters.Length == 0){
        string[] commandNames = registry.GetCommandNames();

        // find max length of command name
        int max = 0;
        foreach (String commandName in commandNames) {
            int length = commandName.Length;
            if (length>max) max = length;
        }

        // præsenter liste over kommandoer
        Console.WriteLine();
        Utility.SlowPrint("Du bladrede til sidste side i din logbog.", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("Der står:", 20);
        Console.WriteLine();
        Utility.SlowPrint("Kommandoer:", 20);
        foreach (String commandName in commandNames) {
            string description = registry.GetCommand(commandName).GetDescription();
            Thread.Sleep(750);
            Console.WriteLine(" - {0,-"+max+"} "+description, commandName);
        }
        Thread.Sleep(1000);
        Console.WriteLine();
        Utility.SlowPrint("De ressourcer du kan finde på øen er plast, metal, træ og pap.", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("Fødevarer du kan finde er fisk og frugt.", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("Hvis du har brug for mere information om de enkelte ressourcer eller fødevarer, spørg om hjælp om dem, så længe du selv har fundet informationen først.", 20);
        Thread.Sleep(1000);
        Utility.SlowPrint("Håber det hjælper!", 20);
        Thread.Sleep(1000);
        Console.WriteLine();
        Utility.SlowPrint("Hvad nu?", 20);
    }
    else{
        switch(parameters[0]){
            case "wow" :
                Console.WriteLine("ddd");
                return;
            default:
                Console.WriteLine("default");
                return;
        }
    }
  }
}
