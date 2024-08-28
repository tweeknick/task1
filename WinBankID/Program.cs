using System;
using System.Collections.Generic;

namespace BankAccountApp
{
    public class BankAccount
    {
        // Властивості
        public string AccountNumber { get; private set; }
        public double Balance { get; private set; }
        public List<string> TransactionHistory { get; private set; }

        // Конструктор
        public BankAccount(string accountNumber, double initialBalance = 0)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            TransactionHistory = new List<string>();
            AddTransaction($"Рахунок створено з балансом: {Balance:C}");
        }

        // Метод для поповнення рахунку
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                AddTransaction($"Поповнення на суму: {amount:C}");
            }
            else
            {
                throw new ArgumentException("Сума для поповнення повинна бути більше нуля.");
            }
        }

        // Метод для зняття грошей з рахунку
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    AddTransaction($"Зняття на суму: {amount:C}");
                }
                else
                {
                    throw new InvalidOperationException("Недостатньо коштів на рахунку.");
                }
            }
            else
            {
                throw new ArgumentException("Сума для зняття повинна бути більше нуля.");
            }
        }

        // Метод для виведення інформації про рахунок
        public string ShowAccountInfo()
        {
            return $"Номер рахунку: {AccountNumber}\nПоточний баланс: {Balance:C}";
        }

        // Метод для додавання транзакції до історії
        private void AddTransaction(string transaction)
        {
            TransactionHistory.Add($"{DateTime.Now}: {transaction}");
        }
    }
}