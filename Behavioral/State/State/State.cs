using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal abstract class State
    {
        Account account;
        double balance;

        protected double interest;
        protected int lowerLimit;
        protected int upperLimit;

        public Account Account 
        { 
            get { return account; } 
            set { account = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public virtual void Deposit(double amount)
        {
            this.balance += amount;
            CheckLimits();
        }
        
        public virtual void Withdraw(double amount)
        {
            if(amount < 0)
            {
                Console.WriteLine("Cannot withdraw since the account is overdrawn");
                return;
            }
            this.balance -= amount;
            CheckLimits();
        }

        public virtual void PayInterest()
        {
            this.balance += this.balance*interest;
            CheckLimits();
        }

        public abstract void Initialize();

        public abstract void CheckLimits();
    }

    internal class RedState : State
    {
        public RedState(State state)
        {
            this.Account = state.Account;
            this.Balance = state.Balance;
            Initialize();
        }

        public void Initialize()
        {
            interest = 0;
            lowerLimit = -500;
            upperLimit = 0;
        }

        public override void CheckLimits()
        {
            if(Balance > upperLimit)
            {
                Account.state = new SilverState(this);
            }
        }
    }

    internal class SilverState : State
    {
        public SilverState(State state) : this(state.Account, state.Balance)
        {
        }

        public SilverState(Account account, double balance)
        {
            this.Account = account;
            this.Balance = balance;
            Initialize();
        }

        public void Initialize()
        {
            interest = 0;
            lowerLimit = 500;
            upperLimit = 1000;
        }
        
        public override void CheckLimits()
        {
            if (Account.Balance < lowerLimit)
            {
                Account.state = new RedState(this);
            }
            else if (this.Balance > upperLimit)
            {
                Account.state = new GoldenState(this);
            }
        }
    }

    internal class GoldenState : State
    {
        public GoldenState(State state)
        {
            this.Account = state.Account;
            this.Balance = state.Balance;
            Initialize();
        }

        public void Initialize()
        {
            interest = 0.05;
            lowerLimit = 1001;
            upperLimit = 50000000;
        }

        public override void CheckLimits()
        {
            if (this.Balance < lowerLimit)
            {
                Account.state = new SilverState(this);
            }
        }
    }

    internal class Account
    {
        public string name;
        public State state;

        public Account(string name)
        {
            this.name = name;
            this.state = new SilverState(this, 0);
        }

        public double Balance
        {
            get { return state.Balance; }
        }

        public void Deposit(double amount)
        {
            state.Deposit(amount);
            Console.WriteLine($"Deposited: {amount}, Balance:{Balance}. Account Type: {state.GetType().Name}");
        }

        public void Withdraw(double amount)
        {
            state.Withdraw(amount);
            Console.WriteLine($"Withdrew: {amount}, Balance:{Balance}. Account Type: {state.GetType().Name}");
        }

        public void PayInterest()
        {
            state.PayInterest();
            Console.WriteLine($"Interest Paid. Balance:{Balance}. Account Type: {state.GetType().Name}");
        }
    }
}
