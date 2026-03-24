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

        public void Deposit (ref double amount)
        {
            if (amount > 0)
            {
                amount += balance;
                Console.WriteLine("Deposit successful");
                Console.WriteLine(balance);
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }
    }

    sealed class Calculator
    {
        public int Add(int a, int b)
        {
            a = 5 + a;
            b = 5 + b;
            return a + b;
        }
    }
}
