/**
 * Player class NOT finished. Base has been established
 * TODO: Implement proper properties and methods.
 * **/

public class Objective
{
    public string title;
    public string description;
    private bool completed;
    private bool current;
    public void Complete()
    {
        completed = true;
        current = false;
    }

    public void Begin()
    {
        current = true;
    }

    public void Present()
    {
        Thread.Sleep(1000);
        Utility.SlowPrint("---------------------------", 10);
        Thread.Sleep(1000);
        Utility.SlowPrint($"{title}");
        Thread.Sleep(1000);
        Utility.SlowPrint("---------------------------",10);
        Thread.Sleep(1000);
        Utility.SlowPrint($"{description}", 40);
        Thread.Sleep(1000);
        Console.WriteLine();
    }
}
