/*
Directions controls the first visit via the hasVisited bool, when the player first enters every area of the game, a custom story message will be played,
giving the player ciritcal information about the current pacakaging problem in the world. After giving the message the bool will be set to true and the message wont 
be displayed the next time the player enters this area.
*/

using System.Net;
using System.Xml;


// Welcome messages for center
public class Center : Space
{
    public Center(String name) : base(name)
    {

    }
    //the bool hasVisited defaults to false, meaning that the player hasnt visited the area yet
    public bool hasVisited;

    public override void Welcome()
    {
        if (hasVisited == false)
        {
            //Custom message played the first time the player enters the area
            Utility.SlowPrint($"This is the first time visiting {name}. You find a newspaper and start reading it.", 20);
            Utility.SlowPrint("In 2022, packaging made up 1,108,000 tons — equivalent to approximately 189.6 kg per citizen in Denmark.", 30);
            Utility.SlowPrint("Around 200,000 tons of that came from plastic packaging — a material that is both costly to produce and is downcycled, meaning it can eventually no longer be recycled.", 30);
            hasVisited = true; //After displaying the message, the hasVisited bool is set to true meaning the message wont play again
            Utility.SlowPrint("You can see these paths:", 20);
            // HashSet is used to find the edges, and what paths you can walk to from the players current position
            HashSet<string> exits = edges.Keys.ToHashSet();
            foreach (String exit in exits)
            {
                Console.WriteLine(" - " + exit);
                Thread.Sleep(500);
            }
            Utility.SlowPrint("What would you like to do now?", 20);
        }
        else // The message that will be played every time the player enters this area after the first time (The build is the same for all areas of the game)
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
// Welcome messages for north
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
            Utility.SlowPrint("If we continue at this rate, global resource extraction will increase by 110% by 2060.", 30);
            Utility.SlowPrint("This represents a significant rise compared to what we have seen over the past 50 years.", 30);
            Utility.SlowPrint("It is particularly critical now that in 2025 we are using more natural resources than ever before.", 30);
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
// Welcome messages for east
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
// Welcome messages for south
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
// Welcome messages for west
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
            Utility.SlowPrint("It thus becomes clear that solving the packaging problem requires a broader effort,", 30);
            Utility.SlowPrint("where both producers and consumers play a role", 30);
            Utility.SlowPrint("in finding a balance between functionality and sustainability.", 30);
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
// Welcome messages for forest
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