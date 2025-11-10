/*
Directions controls the first visit via the hasVisited bool, when the player first enters every area of the game, a custom story message will be played,
giving the player ciritcal information about the current pacakaging problem in the world. After giving the message the bool will be set to true and the message wont 
be displayed the next time the player enters this area.
*/
/*
using System.Net;
using System.Xml;

public class Center : Space
{
    public Center(String name) : base(name)
    {
        
    }
    public bool hasVisited;

    public override void Welcome()
    {
        if (hasVisited == false)
        {
            Utility.SlowPrint($"You find a nearby water source. You estimate that it should last you approximately 7 days.", 20);
            Utility.SlowPrint("You need to find an escape from the island before the water supply slips up!", 30);
            Utility.SlowPrint("On the beach some materials wash ashore. Maybe build a raft?", 30);
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
            Utility.SlowPrint("You are back in the center, you can go any direction on the island from here.", 30);
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
public class North : Space
{
    public North(String name) : base(name)
    {
        
    }
    public bool hasVisited;

    public override void Welcome()
    {
        if (hasVisited == false)
        {
            Utility.SlowPrint($"This is the first time visiting {name}. You find a newspaper and start reading it.", 20);
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
            Utility.SlowPrint("You are back in the northeren part of the island.", 30);
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
public class South : Space
{
    public South(String name) : base(name)
    {
        
    }
    public bool hasVisited;

    public override void Welcome()
    {
        if (hasVisited == false)
        {
            Utility.SlowPrint($"This is the first time visiting {name}. You find a newspaper and start reading it.", 20);
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
            Utility.SlowPrint("You are back in the southeren part of the island.", 30);
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

public class Forest : Space
{
    public Forest(String name) : base(name)
    {

    }
    public bool hasVisited;
    public override void Welcome()
    {
        if (hasVisited == false)
        {
            Utility.SlowPrint($"This is the first time visiting {name}. You find a newspaper and start reading it.", 20);
            Utility.SlowPrint("Although cardboard- and paper-based packaging and wrapping is recyclable, and the supply of trees is technically an endless resource,", 30);
            Utility.SlowPrint("we are limited by the fact that we cut down about 10 billion more trees each year than we plant. The trees we plant today will only be ready to use in 10 - 20 years.", 30);
            Utility.SlowPrint("This means that an endless and recyclable resource can still run out over time.", 30);
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
            Utility.SlowPrint("You are back in the forest, chop down trees or collect some fruits", 30);
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
  // Welcome messages for Ocean
public class Ocean : Space{
    public Ocean(String name): base(name)
    {
        
    }
    public override void Welcome()
    {
        if (hasVisited == false)
        {
            Utility.SlowPrint("A lot of plastic ends up as microplastics in nature, and due to its strength, it takes an extremely long time to decompose.", 30);
            Utility.SlowPrint("11 million tons of plastic waste find their way into our oceans through incorrect sorting and waste dumping at sea. These 11 million tons", 30);
            Utility.SlowPrint("are just a small addition to the already 200 million tons that are already in the worlds oceans. At this rate of production and waste, there will be more plastic than fish in the ocean by 2050.", 30);
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
                Utility.SlowPrint("You are back in the forest, chop down trees or collect some fruits", 30);
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
*/