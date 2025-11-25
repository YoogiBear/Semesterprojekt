/* Main class for launching the game
 */

public class Resource
{
    public string Name { get; }
    public int Pollution { get; }
    public int Weight { get; }
    public int Strength { get; }

    public Resource(string name = "defaultName", int pollution = 10, int weight = 0, int strength = 0)
    {
        Name = name;
        Pollution = pollution;
        Weight = weight;
        Strength = strength;
    }
}