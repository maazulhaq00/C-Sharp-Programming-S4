using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOPs_Abstraction
{
    internal class CreditCardPayment : Payment
    {
        public CreditCardPayment(double amount) : base(amount)
        {
        }

        public override void MakePayment()
        {
            Console.WriteLine("Payement Done using Credit Card");
        }
    }
}
