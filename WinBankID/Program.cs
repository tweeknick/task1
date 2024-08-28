using System;
using System.Collections.Generic;

namespace BankAccountApp
{
    public class BankAccount
    {
        // ����������
        public string AccountNumber { get; private set; }
        public double Balance { get; private set; }
        public List<string> TransactionHistory { get; private set; }

        // �����������
        public BankAccount(string accountNumber, double initialBalance = 0)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            TransactionHistory = new List<string>();
            AddTransaction($"������� �������� � ��������: {Balance:C}");
        }

        // ����� ��� ���������� �������
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                AddTransaction($"���������� �� ����: {amount:C}");
            }
            else
            {
                throw new ArgumentException("���� ��� ���������� ������� ���� ����� ����.");
            }
        }

        // ����� ��� ������ ������ � �������
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    AddTransaction($"������ �� ����: {amount:C}");
                }
                else
                {
                    throw new InvalidOperationException("����������� ����� �� �������.");
                }
            }
            else
            {
                throw new ArgumentException("���� ��� ������ ������� ���� ����� ����.");
            }
        }

        // ����� ��� ��������� ���������� ��� �������
        public string ShowAccountInfo()
        {
            return $"����� �������: {AccountNumber}\n�������� ������: {Balance:C}";
        }

        // ����� ��� ��������� ���������� �� �����
        private void AddTransaction(string transaction)
        {
            TransactionHistory.Add($"{DateTime.Now}: {transaction}");
        }
    }
}