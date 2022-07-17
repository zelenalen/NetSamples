namespace NetSamples.Delegates;

public class WelcomeMessagePrinter
{
    public string MessageText { get; set; }

    public WelcomeMessagePrinter()
    {
        MessageText = "Welcome user!";
    }

    public void Print()
    {
        Console.WriteLine(MessageText);
    }
}