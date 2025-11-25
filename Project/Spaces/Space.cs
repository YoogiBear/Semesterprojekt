/* Space class for modeling spaces (rooms, caves, ...)
 */

public class Space : Node {

    public Space (String name) : base(name)
  {

  }
    public virtual void Welcome () {
        Utility.SlowPrint($"Du befinder dig her: {name}.", 10);
        HashSet<string> exits = edges.Keys.ToHashSet();
        Thread.Sleep(500);
        Utility.SlowPrint("Du kan se disse stier:", 20);
        foreach (String exit in exits)
        {
            Console.WriteLine(" - " + exit);
            Thread.Sleep(500);
        }

        Console.WriteLine();
        Utility.SlowPrint("Hvad vil du gerne gøre nu?", 20);
    }

    public void Goodbye () {
  }
  
  public override Space FollowEdge (string direction) {
    return (Space) (base.FollowEdge(direction));
  }
}
