using System.Text;

namespace NetSamples.DelegatesRealSample;

public class Bank
{
    public List<BankAccount> Accounts = new  List<BankAccount>();

    public void OpenAccount(BankAccount bankAccount)
    {
        Accounts.Add(bankAccount);
        bankAccount.Notify += SmsNotify;
    }

    public void CloseAccount(BankAccount bankAccount)
    {

    }


    public void SmsNotify(BankAccount sender, BankAccountNotificationEventArgs eventArgs)
    {
        var targetPhoneNumber = sender.PhoneNumber;

        var sb = new StringBuilder();
        sb.Append(eventArgs.Message);
        sb.Append(Environment.NewLine);
        sb.Append($"Actual state: {eventArgs.Sum}");
        

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(sb.ToString());
        Console.ResetColor();
    }
}