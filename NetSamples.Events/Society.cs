namespace NetSamples.Events;

public class Society 
{
    public List<Human> Humans { get; set; }
    public WatchDog WatchDog { get; set; }
    public Camera Camera { get; set; }
    

    public Society()
    {
        Humans = new List<Human>();
        Camera = new Camera();
        WatchDog = new WatchDog();

        Camera.NotifyWatchDog += WatchDog.DoSmth;
    }

    public void Add(Human human)
    {
        Humans.Add(human);
        Humans.Last().Notify += Camera.CheckLoyalty;
    }
}