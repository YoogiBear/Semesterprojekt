/*
Look center class for code explantion
*/
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