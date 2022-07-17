namespace NetSamples.DelegatesRealSample;

public class BankAccountNotificationEventArgs
{
    public Guid AccountId { get; }
    public string Message { get; }
    public int DeltaSum { get; }
    public int Sum { get; }

    public BankAccountNotificationEventArgs(Guid id, string message, int deltaSum, int sum)
    {
        AccountId = id;
        Message = message;
        DeltaSum = deltaSum;
        Sum = sum;
    }
}