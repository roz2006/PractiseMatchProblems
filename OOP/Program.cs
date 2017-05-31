using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccounts myBankAccount = new BankAccounts(123456, 176);
            myBankAccount.Deposit(1200);
            Console.WriteLine(myBankAccount.GetBalance());
        }
    }
}
