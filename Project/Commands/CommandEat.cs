/* Command for Player eating Food
 */

class CommandEat : BaseCommand, ICommand {
  public CommandEat () {
    description = "You ate Food";
  }
  
    //attempts to execute EatCommand with given context, command and given parameters else return
  public void Execute (string command, string[] parameters) {
    if (GuardEq(parameters, 1)) {
      Console.WriteLine("I don't seem to know where that is 🤔");
      return;
    }
    context.Transition(parameters[0]);
  }
}
