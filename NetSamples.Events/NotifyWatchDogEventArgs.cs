namespace NetSamples.Events;

public class NotifyWatchDogEventArgs
{
    public Guid HumanId { get; }
    public int ActualRating { get; }

    public NotifyWatchDogEventArgs(Guid humanId, int actualRating)
    {
        HumanId = humanId;
        ActualRating = actualRating;
    }

}