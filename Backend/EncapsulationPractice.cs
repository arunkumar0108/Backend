using System;
using System.Collections.Generic;
using System.Text;

namespace Backend
{
    public class EncapsulationPractice
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
            }
        }

        public void Deposit (double amount)
        {
            if (amount > 0)
            {
                amount += balance;
                Console.WriteLine("Deposit successful");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }
    }
}
