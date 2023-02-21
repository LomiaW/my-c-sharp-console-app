using System;

namespace MySimpleBank
{
  class Program
  {
    static void Main(string[] args)
    {
      var account = new BankAccount("Mia", 10000);
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
      
      account.MakeWithdrawal(2500, DateTime.Now, "Rent payment");
      Console.WriteLine(account.Balance);
      
      account.MakeDeposit(500, DateTime.Now, "Jackpot");
      Console.WriteLine(account.Balance);

      Console.WriteLine(account.GetAccountHistory());
    }
  }
}