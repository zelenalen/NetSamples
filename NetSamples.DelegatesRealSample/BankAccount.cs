namespace NetSamples.DelegatesRealSample;

public delegate void AccountNotificationHandler(string message);

public class BankAccount
{
    private int _sum;
    private AccountNotificationHandler _notificationHandler;

    public BankAccount(int sum)
    {
        _sum = sum;
    }

    public void RegisterNotificationHandler(AccountNotificationHandler handler)
    {
        _notificationHandler += handler;
    } 
    public void UnregisterNotificationHandler(AccountNotificationHandler handler)
    {
        _notificationHandler -= handler;
    }

    public void Add(int sum)
    {
        _sum += sum;
    }

    public void CashWithdraw(int sum)
    {
        if (_sum >= sum)
        {
            _sum -= sum;

            _notificationHandler?.Invoke($"You take {sum} from your account");
        }
        else
        {
            _notificationHandler?.Invoke($"You don't have enough money on your account. Actual account state {_sum}");
        }
    }
}