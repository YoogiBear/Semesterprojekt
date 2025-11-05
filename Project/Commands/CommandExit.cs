/* Command for exiting program at any time
 */

class CommandExit : BaseCommand, ICommand {
    public CommandExit()
    {
        description = "Ends the game.";
    }
  public void Execute (Context context, string command, string[] parameters) {
    context.MakeDone();
  }
}
