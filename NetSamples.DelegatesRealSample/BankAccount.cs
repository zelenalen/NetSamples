namespace NetSamples.DelegatesRealSample;

public delegate void AccountNotificationHandler(BankAccount sender, BankAccountNotificationEventArgs eventArgs);

public class BankAccount
{
    public Guid AccountId { get; }
    public string PhoneNumber { get; }
    private int _sum;
    private AccountNotificationHandler _notificationHandler;
    public event AccountNotificationHandler Notify;


    public BankAccount(int sum)
    {
        AccountId = Guid.NewGuid();
        _sum = sum;
    }

    //public void RegisterNotificationHandler(AccountNotificationHandler handler)
    //{
    //    _notificationHandler += handler;
    //} 
    //public void UnregisterNotificationHandler(AccountNotificationHandler handler)
    //{
    //    _notificationHandler -= handler;
    //}

    public void Add(int sum)
    {
        _sum += sum;
    }

    public void CashWithdraw(int sum)
    {
        if (_sum >= sum)
        {
            _sum -= sum;

            //if (Notify != null)
            //{
            //    Notify($"You take {sum} from your account");
            //}
            Notify?.Invoke(this, 
                new BankAccountNotificationEventArgs
                    (AccountId, 
                        $"You take {sum} from your account", 
                        sum, 
                        _sum));
            //_notificationHandler?.Invoke($"You take {sum} from your account");
        }
        else
        {
            Notify?.Invoke(this, new BankAccountNotificationEventArgs(AccountId, $"You don't have enough money on your account", sum, _sum));

            //_notificationHandler?.Invoke($"You don't have enough money on your account. Actual account state {_sum}");
        }
    }
}