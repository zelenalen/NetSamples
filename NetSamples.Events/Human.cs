namespace NetSamples.Events;

public delegate void ThingNotificationHandler(Human sender, ThingNotificationEventArgs eventArgs);


public class Human
{
    public Guid Id { get; set; }
    public int SocialRating { get; set; }
    public event ThingNotificationHandler Notify;

    public Human()
    {
        Id = Guid.NewGuid();
        SocialRating = 0;
    }

    public void Do()
    {
        var typeOfThing = new Random().Next(0, 5);

        var type = (Thing)typeOfThing;

        Notify?.Invoke(this, new ThingNotificationEventArgs(type));
    }

}