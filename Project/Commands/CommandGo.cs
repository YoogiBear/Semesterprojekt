/* Command for transitioning between allowed spaces
 */

class CommandGo : BaseCommand, ICommand {
  public CommandGo () {
    description = "Used to traverse the island. Write 'go' followed by a valid direction. ";
  }
  
    //attempts to execute GoCommand with given context, command and given parameters else return 
  public void Execute (Context context, string command, string[] parameters) {
    if (GuardEq(parameters, 1)) {
      Console.WriteLine("I don't seem to know where that is 🤔");
      return;
    }
    context.Transition(parameters[0]);
  }
}
