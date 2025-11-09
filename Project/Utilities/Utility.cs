/* Main class for launching the game
 */

public static class Utility
{
    // This class allows text to be written out letter by letter with an option to skip by pressing any key.
    public static void SlowPrint(string text, int time = 100, bool skipWithKey = true)
    {
        if (string.IsNullOrEmpty(text)) // check for null or empty string (just in case)
        {
            Console.WriteLine();
            return;
        }

        // goes through each character in the string
        for (int i = 0; i < text.Length; i++)
        {
            // If the user pressed a key, consume it and print the rest immediately
            if (skipWithKey && Console.KeyAvailable)
            {
                Console.ReadKey(true); // consume key without echo
                Console.Write(text.Substring(i)); // print the rest of the string
                break; // exit the loop and skips to next string text
            }

            Console.Write(text[i]); // prints one character
            Thread.Sleep(Math.Max(0, time)); // waits for specified time (in milliseconds) (Math.Max to avoid negative sleep time)
        }

        Console.WriteLine(); // move to the next line after printing the whole string
    }
}


