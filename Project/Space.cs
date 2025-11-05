/* Space class for modeling spaces (rooms, caves, ...)
 */

public class Space : Node {
  public Space (String name) : base(name)
  {

  }
    public void Welcome () {
        Utility.SlowPrint($"Currently you are at {name}.", 10);
        HashSet<string> exits = edges.Keys.ToHashSet();
        Thread.Sleep(500);
        Utility.SlowPrint("You can see these paths:", 20);
        foreach (String exit in exits)
        {
            Console.WriteLine(" - " + exit);
            Thread.Sleep(500);
        }

        Console.WriteLine();
        Utility.SlowPrint("What would you like to do now?", 20);
    }

    public void Goodbye () {
  }
  
  public override Space FollowEdge (string direction) {
    return (Space) (base.FollowEdge(direction));
  }
}
