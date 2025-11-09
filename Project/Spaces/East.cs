/*
Look center class for code explantion
*/

public class East : Space
{
   public East(String name) : base(name)
    {
        
    }
   public bool hasVisited;

    public override void Welcome()
    {
        if (hasVisited == false)
        {
            Utility.SlowPrint($"This is the first time visiting {name}. You find a newspaper and start reading it.", 20);
            Utility.SlowPrint("Packaging serves an important function as it protects products during transport and extends their shelf life, which helps reduce food waste.", 30);
            Utility.SlowPrint("This creates a dilemma between the need for functional packaging", 30);
            Utility.SlowPrint("and the desire to reduce environmental impact.", 30);
            hasVisited = true;
            Utility.SlowPrint("You can see these paths:", 20);
            HashSet<string> exits = edges.Keys.ToHashSet();
            foreach (String exit in exits)
            {
                Console.WriteLine(" - " + exit);
                Thread.Sleep(500);
            }
            Utility.SlowPrint("What would you like to do now?", 20);
        }
        else
        {
            Utility.SlowPrint("You are back in the eastern part of the island.", 30);
            Utility.SlowPrint("You can see these paths:", 20);
            HashSet<string> exits = edges.Keys.ToHashSet();
            foreach (String exit in exits)
            {
                Console.WriteLine(" - " + exit);
                Thread.Sleep(500);
            }
                Utility.SlowPrint("What would you like to do now?", 20);

        }
    }
}

