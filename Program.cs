using System;

namespace learn_dotnet_classes_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Santosh Marigowda", 1000);
            Console.WriteLine($"Account {account.Number} is created for {account.Owner} with {account.Balance} initial balance");
        }
    }
}
