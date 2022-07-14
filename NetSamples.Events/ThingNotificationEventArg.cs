namespace NetSamples.Events;

public class ThingNotificationEventArgs
{
    public Thing ThingType { get; }

    public ThingNotificationEventArgs(Thing thingType)
    {
        ThingType = thingType;
    }
}