/*
<<<<<<< HEAD
Look center class for code explantion
=======
Center class is only for the hasVisited at the start for the story line
>>>>>>> ba37c26b4484f13c2712bb3efe1cb4dfacadb930
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
            Utility.SlowPrint("In 2022, packaging made up 1,108,000 tons — equivalent to approximately 189.6 kg per citizen in Denmark.", 30);
            Utility.SlowPrint(" Around 200,000 tons of that came from plastic packaging — a material that is both costly to produce and is downcycled, meaning it can eventually no longer be recycled.", 30);
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

