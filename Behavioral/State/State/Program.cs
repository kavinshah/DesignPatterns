// See https://aka.ms/new-console-template for more information

using State;

Account account = new Account("Kavin");
account.Deposit(300);
account.Deposit(500);
account.Deposit(500);
account.PayInterest();
account.Withdraw(100);
account.Withdraw(1000);
account.Withdraw(300);
