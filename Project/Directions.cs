/*
Center class is only for the hasVisited at the start for the story line
*/

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
            Utility.SlowPrint($"This is the first time visiting {name}. You find a newspaper and start reading it.", 20);
            Utility.SlowPrint("In 2022, packaging made up 1,108,000 tons — equivalent to approximately 189.6 kg per citizen in Denmark.", 30);
            Utility.SlowPrint(" Around 200,000 tons of that came from plastic packaging — a material that is both costly to produce and is downcycled, meaning it can eventually no longer be recycled.", 30);
            hasVisited = true;
        }
        else
        {
            Utility.SlowPrint("You are back in the center, you can go any direction on the island from here.", 30);
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
        }
        else
        {
            Utility.SlowPrint("You are back in the northeren part of the island.", 30);
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
        }
        else
        {
            Utility.SlowPrint("You are back in the eastern part of the island.", 30);
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
        }
        else
        {
            Utility.SlowPrint("You are back in the southeren part of the island.", 30);
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
        }
        else
        {
            Utility.SlowPrint("You are back in the western part of the island.", 30);
        }
    }
}
