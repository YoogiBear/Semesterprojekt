/*
Look center class for code explantion
*/

public class West : Space
{
    public West(String name) : base(name)
    {

    }
    public bool hasVisited;

    public override void Welcome()
    {
        if (hasVisited == false)
        {
            Utility.SlowPrint($"This is the first time visiting {name}. You find a newspaper and start reading it.", 20);
            Utility.SlowPrint("The disadvantage of wood-based packaging lies in the recycling process, where the fibers can be reused a maximum of seven times.", 30);
            Utility.SlowPrint("Another drawback is the use of PFAS substances in many paper and cardboard productions.", 30);
            Utility.SlowPrint("PFAS are a group of fluorinated chemical compounds that, among other things, provide a water-repellent effect on clothing.", 30);
            Utility.SlowPrint("Some types are harmful to humans and can cause liver damage and fertility problems, but they all share the trait of being difficult to break down in nature.", 30);
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
            Utility.SlowPrint("You are back in the western part of the island.", 30);
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

