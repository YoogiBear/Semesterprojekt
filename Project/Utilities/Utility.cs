/* Main class for launching the game
 */

public static class Utility
{
    // This class allows text to be written out letter by letter with spaces in between, for added effect.
    public static void SlowPrint(string text, int time = 100)
    {
        text.ToCharArray();
        foreach (char ch in text)
        {
            Console.Write(ch.ToString());
            Console.Write("");
            Thread.Sleep(time);
        }
        Console.WriteLine();
    }

}


