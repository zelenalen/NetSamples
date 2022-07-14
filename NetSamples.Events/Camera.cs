namespace NetSamples.Events;

public delegate void NotifyWatchDogHandler(Camera sender, NotifyWatchDogEventArgs eventArgs);

public class Camera
{
    public event NotifyWatchDogHandler NotifyWatchDog;

    public void CheckLoyalty(Human sender, ThingNotificationEventArgs eventArgs)
    {
        switch (eventArgs.ThingType)
        {
            case Thing.Neutral:
                break;
            case Thing.Good:
                sender.SocialRating++;
                break;
            case Thing.VeryGood:
                sender.SocialRating += 3;
                if (sender.SocialRating >= 5)
                {
                    NotifyWatchDog?.Invoke(this, new NotifyWatchDogEventArgs(sender.Id, sender.SocialRating));
                }
                break;
            case Thing.Bad:
                sender.SocialRating--;
                if (sender.SocialRating <= -2)
                {
                    NotifyWatchDog?.Invoke(this, new NotifyWatchDogEventArgs(sender.Id, sender.SocialRating));
                }
                break;
            case Thing.VeryBad:
                sender.SocialRating-=5;
                if (sender.SocialRating <= -2)
                {
                    NotifyWatchDog?.Invoke(this, new NotifyWatchDogEventArgs(sender.Id, sender.SocialRating));
                }
                break;
        }
    }
}