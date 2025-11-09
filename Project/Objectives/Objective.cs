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


    public void Present()
    {
        int wait = 500;
        Thread.Sleep(wait);
        Utility.SlowPrint("---------------------------", 5);
        Thread.Sleep(wait);
        Utility.SlowPrint($"{title}", 20);
        Thread.Sleep(wait);
        Utility.SlowPrint("---------------------------", 5);
        Thread.Sleep(wait);
        Utility.SlowPrint($"{description}", 20);
        Thread.Sleep(wait);
        Console.WriteLine();
    }

    public void Begin()
    {
        current = true;
    }

    public void Complete()
    {
        completed = true;
        current = false;
    }


}
