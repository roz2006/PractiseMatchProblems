using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class BankAccounts
    {
        private int _accountNumber;
        private decimal _balance;
        private static int s_NextAccountNumber;

        private static int GetNextAccountNumber()
        {
            s_NextAccountNumber++;
            return s_NextAccountNumber;
        }

        public int AccountNumber { get => _accountNumber; private set => _accountNumber = value; }

        public BankAccounts(int ac,decimal bal=0)
        {
            this.AccountNumber = ac;
            this._balance = bal;
        }
        public decimal GetBalance()
        {
            return this._balance;
        }
        public void Deposit(decimal deposit)
        {
            this._balance += deposit;
        }
        public bool WithDraw(decimal money)
        {
            if (money > this._balance)
                return false;
            else
            { this._balance -= money;return true; }
        }

    }
}
