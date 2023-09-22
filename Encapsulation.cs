using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPrograms
{
    class BankAccount
    {
        private decimal balance;
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }
        public decimal GetBalance()
        {
            return balance;
        }
    }
    public class Encapsulation
    {
        public static void main()
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            Console.WriteLine($"final balance: {account.GetBalance()}");
        }
    }
}
