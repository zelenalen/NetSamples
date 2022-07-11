namespace NetSamples.DelegatesRealSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(1000);

            account.RegisterNotificationHandler(PrintMessage);
            account.RegisterNotificationHandler(PrintRedMessage);
            account.RegisterNotificationHandler(SendEmail);

            account.CashWithdraw(500);
            account.CashWithdraw(700);
            account.UnregisterNotificationHandler(PrintRedMessage);
            account.CashWithdraw(700);
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void PrintRedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void SendEmail(string message)
        {
            var x = message;

        }

    }
}