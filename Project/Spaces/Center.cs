/*
Center class is only for the hasVisited at the start for the story line
*/

public class Center : Space
{
    public Center(String name) : base(name)
    {


    }
    //hasVisited ool set to false, meaning the player hasnt been in this area of the map yet.

    public bool hasVisited;

    public override void Welcome()
    {
        if (hasVisited == false) //If the player hasnt been here before i plays the custom message.
        {
            Utility.SlowPrint($"This is the first time visiting {name}. You find a newspaper and start reading it.", 20);
            Utility.SlowPrint("In 2022, packaging made up 1,108,000 tons — equivalent to approximately 189.6 kg per citizen in Denmark.", 30);
            Utility.SlowPrint("Around 200,000 tons of that came from plastic packaging — a material that is both costly to produce and is downcycled, meaning it can eventually no longer be recycled.", 30);
            hasVisited = true; //Sets hasVisisted to true, meaning the player wont get the custom message anymore
            Utility.SlowPrint("You can see these paths:", 20);
            // Hashset is used to check the edges for which paths are open from this area

            HashSet<string> exits = edges.Keys.ToHashSet();
            foreach (String exit in exits)
            {
                Console.WriteLine(" - " + exit);
                Thread.Sleep(500);
            }
            Utility.SlowPrint("What would you like to do now?", 20);
        }

        else //If the player has been here and hasVisited is true, this will be displayed from now on when the player enters this area

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

