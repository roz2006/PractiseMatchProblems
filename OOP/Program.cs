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

            //Print(a: "First", c: "C is given");
            //Console.WriteLine();
            //Print("Second", "no default b", "C is given as two strings", @"C's second part");

        }

        //static void Print(string a = "Default", string b = "default middle", params string[] c)
        //{
        //    Console.Write(a + ","+ b +",");
        //    for (int i = 0; i < c.Length; i++)
        //    {
        //        Console.Write(c[i]+" ");

        //    }

    }
}
