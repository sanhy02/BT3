using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDaHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac1 = new SavingAccount(200);
            Account ac2 = new CheckingAccount(200);
            Console.ReadLine();
        }
    }
}