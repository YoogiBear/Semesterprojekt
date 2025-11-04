/* Main class for launching the game
 */

public static class Pollution
{
    // Pollution
    public static int level;
    public static int Level => level;

    // Increase pollution by amount
    public static void AddPollution(int amount)
    {
        if (amount <= 0) return;
        level += amount;
        Console.WriteLine($"Pollution increased by {amount}. Current level: {level}");
    }
}
