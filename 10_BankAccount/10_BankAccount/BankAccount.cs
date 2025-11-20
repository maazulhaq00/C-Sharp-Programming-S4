using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_BankAccount
{
    internal class BankAccount
    {
        private string accountHolder;
        private int pin;
        private int balance;

        public BankAccount(string accountHolder, int pin, int balance)
        {
            this.accountHolder = accountHolder;
            this.pin = pin;
            this.balance = balance;
        }

        public BankAccount(string accountHolder, int pin)
        {
            this.accountHolder = accountHolder;
            this.pin = pin;
            this.balance = 0;
        }

        public void checkBalance(int inputPin)
        {
            if (inputPin == this.pin)
            {
                Console.WriteLine($"Dear {this.accountHolder}, you current account balance is Rs. {this.balance}");
            }
            else
            {
                Console.WriteLine("Sorry! incorrect pin.");
            }
        }
        public void deposit(int inputPin, int amount)
        {
            if (inputPin == this.pin)
            {
                this.balance += amount; // b = b + a ==> b += a

                Console.WriteLine($"Dear {this.accountHolder}, amount depositted successfully, you updated account balance is Rs. {this.balance}");
            }
            else
            {
                Console.WriteLine("Sorry! incorrect pin.");
            }
        }

        public void withdaw(int inputPin, int amount)
        {
            if (inputPin == this.pin)
            {
                if(this.balance >= amount)
                {
                    this.balance -= amount; // b = b + a ==> b += a

                    Console.WriteLine($"Dear {this.accountHolder}, amount withdraw successfully, you updated account balance is Rs. {this.balance}");

                }
                else
                {
                    Console.WriteLine($"Dear {this.accountHolder}, Sorry insufficient funds, you currect account balance is Rs. {this.balance}");

                }
            }
            else
            {
                Console.WriteLine("Sorry! incorrect pin.");
            }
        }

    }
}
