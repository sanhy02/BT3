using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDaHinh
{
    class SavingAccount : Account
    {
        private double interseBate = 0.8;
        public SavingAccount() : base()
        {

        }
        public SavingAccount(double balance) : base(balance)
        {

        }
        public double InteresRate
        {
            set { interseBate = value; }
            get { return interseBate; }
        }
        public override bool WithDraw(double amount)
        {
            return false;
        }
        public override bool Deposit(double amount)
        {
            return false;
        }
    }
}