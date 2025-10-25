/* Command for exiting program at any time
 */

class CommandExit : BaseCommand, ICommand {
  public void Execute (Context context, string command, string[] parameters) {
    context.MakeDone();
  }
}
