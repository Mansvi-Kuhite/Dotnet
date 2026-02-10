using System;

namespace OOPFundamentals.Lab2
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; private set; }

        public bool IsOverdrawn => Balance < 0;

        public BankAccount(string name, decimal initialBalance)
        {
            AccountHolder = name;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Invalid deposit amount");

            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Invalid withdraw amount");

            Balance -= amount;
        }
    }
}
