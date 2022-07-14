namespace NetSamples.Events;

public class WatchDog
{
    public void DoSmth(Camera sender, NotifyWatchDogEventArgs eventArgs)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        if (eventArgs.ActualRating >=5)
        {
            Console.WriteLine($"{eventArgs.HumanId} got a medal");
        }
        else if (eventArgs.ActualRating == -2)
        {
            Console.WriteLine($"{eventArgs.HumanId} was placed to jail");
        }
        else
        {
            Console.WriteLine($"{eventArgs.HumanId} was silently killed in the night");
        }
        Console.ResetColor();
    }
}