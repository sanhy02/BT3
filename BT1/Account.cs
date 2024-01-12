using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDaHinh
{
    class Account
    {
        private double balance;
        public Account()
        {

        }
        public Account(double balance)
        {
            this.balance = balance;
        }
        public double Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public virtual bool WithDraw(double amount)
        {
            return false;
        }
        public virtual bool Deposit(double amount)
        {
            return false;
        }
        public void PrintBalance()
        {
            Console.WriteLine("balance: {0}", balance);
        }
    }
}