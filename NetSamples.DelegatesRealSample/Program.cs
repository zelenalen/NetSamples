using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace NetSamples.DelegatesRealSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(1000);
            var account2 = new BankAccount(2000);

            var bank = new Bank();
            bank.OpenAccount(account);
            bank.OpenAccount(account2);


            //bank.Accounts[0].Notify += PrintMessage;
            //bank.Accounts[1].Notify += PrintRedMessage;

            bank.Accounts[0].CashWithdraw(500);
            bank.Accounts[1].CashWithdraw(700);
            bank.Accounts[1].CashWithdraw(700);
            bank.Accounts[1].CashWithdraw(700);

            var obsCollection = new ObservableCollection<int>();
            obsCollection.CollectionChanged += 
                (sender, eventArgs) =>
            {
                switch (eventArgs.Action)
                {
                    case NotifyCollectionChangedAction.Add:

                        Console.WriteLine($"{sender} was changed");
                        Console.WriteLine($"{eventArgs.NewItems[0]} was added");
                        break;
                }

               
            };

            obsCollection.Add(1);

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