using System;

namespace ImplementABankingApplicationUsingPolymorphism
{
    class Account
    {
        private double _balance;

        public Account(double balance)
        {
            this._balance = balance;
        }
        protected double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public virtual bool Withdraw(double amount)
        {
            return false;
        }

        public virtual bool Deposit(double amount)
        {
            return false;
        }

        public virtual void PrintBalance()
        {
            Console.WriteLine(this._balance);
        }
    }

    class SavingsAccount : Account
    {
        private double _interestRate = 0.8;

        public SavingsAccount(double balance) : base(balance) { }

        public override bool Withdraw(double amount)
        {
            if (base.Balance >= amount && amount > 0)
            {
                base.Balance = base.Balance - (amount + (amount * this._interestRate));
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                base.Balance = base.Balance + (amount + (amount * this._interestRate));
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class CheckingAccount : Account
    {
        public CheckingAccount(double balance) : base(balance) { }

        public override bool Withdraw(double amount)
        {
            if (base.Balance >= amount)
            {
                base.Balance = base.Balance - amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                base.Balance = base.Balance + amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void PrintBalance()
        {
            Console.WriteLine(base.Balance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account SAccount = new SavingsAccount(5000);
            SAccount.Deposit(1000);
            SAccount.PrintBalance();

            SAccount.Withdraw(3000);
            SAccount.PrintBalance();

            Account CAccount = new CheckingAccount(5000);
            CAccount.Deposit(1000);
            CAccount.PrintBalance();

            CAccount.Withdraw(3000);
            CAccount.PrintBalance();
        }
    }
}
