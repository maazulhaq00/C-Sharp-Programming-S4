using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OOPs_Interface
{
    internal interface INotification
    {
        void Send(string message);
    }

    class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
    class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}
