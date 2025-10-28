using System;
using System.Collections.Generic;

// Simple Trash model
public class Trash
{
    // weight is how much pollution this trash generates when added
    public int Weight { get; }

    public Trash(int weight)
    {
        if (weight < 0) throw new ArgumentException("Weight can't be negative", nameof(weight));
        Weight = weight;
    }
}

// Pollution component (only increases)
public class Pollution
{
    public int level;
    public int Level => level;

    public Pollution(int initialLevel = 0)
    {
        if (initialLevel < 0) throw new ArgumentException("Initial level must be 0", nameof(initialLevel));
        level = initialLevel;
    }

    // Increase pollution by amount (e.g., when trash is added)
    public void AddPollution(int amount)
    {
        if (amount <= 0) return;
        level += amount;
        Console.WriteLine($"Pollution increased by {amount}. Current level: {level}");
    }
}

// Food generator component
public class FoodGenerator
{
    private readonly List<string> foodSources = new List<string>();
    public IReadOnlyList<string> FoodSources => foodSources.AsReadOnly();

    public void GenerateFish(int count)
    {
        if (count <= 0) return;
        for (int i = 0; i < count; i++)
        {
            foodSources.Add("Fish");
        }
        Console.WriteLine($"{count} fish generated.");
    }
}

// Ocean composes Pollution and FoodGenerator
public class Ocean
{
    public Pollution Pollution { get; }
    public FoodGenerator Food { get; }

    // Optional: pollutionFactor lets you translate trash weight into pollution
    private readonly int pollutionFactor;

    public Ocean(int initialPollution = 0, int pollutionFactor = 1)
    {
        Pollution = new Pollution(initialPollution);
        Food = new FoodGenerator();
        this.pollutionFactor = Math.Max(1, pollutionFactor);
    }

    // Add Trash object -> increases pollution immediately
    public void AddTrash(Trash trash)
    {
        if (trash == null) throw new ArgumentNullException(nameof(trash));
        int added = trash.Weight * pollutionFactor;
        Pollution.AddPollution(added);
    }

    // Add raw amount of trash (weight)
    public void AddTrash(int weight)
    {
        if (weight <= 0) return;
        int added = weight * pollutionFactor;
        Pollution.AddPollution(added);
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Pollution Level: {Pollution.Level}");
        Console.WriteLine("Food sources: " + (Food.FoodSources.Count == 0 ? "(none)" : string.Join(", ", Food.FoodSources)));
    }
}

// Example usage
public class Program
{
    public static void Main(string[] args)
    {
        var ocean = new Ocean(initialPollution: 10, pollutionFactor: 2); // each unit of trash = 2 pollution
        ocean.ShowStatus();

        // Add some fish
        ocean.Food.GenerateFish(3);

        // Add trash as an object
        var trash1 = new Trash(weight: 5);
        ocean.AddTrash(trash1); // increases pollution by 5*2 = 10

        // Add raw trash amount
        ocean.AddTrash(3); // increases pollution by 3*2 = 6

        ocean.ShowStatus();
    }
}
