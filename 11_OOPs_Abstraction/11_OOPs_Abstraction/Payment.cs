using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOPs_Abstraction
{
    abstract class Payment
    {

        public double Amount;

        public Payment(double amount) {
            this.Amount = amount;
        }

        public abstract void MakePayment();

        public void ShowRecipt()
        {
            Console.WriteLine($"Recipt generated fro amount {this.Amount}");
        }

    }
}
