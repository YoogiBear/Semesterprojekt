/* Command for exiting program at any time
 */

class CommandExit : BaseCommand, ICommand {
    public CommandExit()
    {
        description = "Slutter spillet.";
    }
  public void Execute (Context context, string command, string[] parameters) {
    context.MakeDone();
  }
}
