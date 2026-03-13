using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace Backend
{
    public class TaskBeginner
    {
        public void VarTask()
        {
            var Name = "Jack";
            var Age = 20;
            var Salary = 30000;
            var IsEmployee = true;

            Console.WriteLine($"Name: {Name}\nAge: {Age}\nSalary: {Salary}\nIs Employee: {IsEmployee}\n");
        }

        public void DataTypeTask()
        {
            int number = 10;
            double price = 25.5;
            string name = "Jack";
            bool isActive = true;
            char letter = 'A';

            Console.WriteLine($"Number: {number}\nPrice: {price}\nLetter: {letter}\nName: {name}\nIsActive: {isActive}\n");

        }

        public void OperatorTask()
        {
            int a = 20;
            int b = 10;

            Console.WriteLine($"Add: {a + b}");
            Console.WriteLine($"Sub: {a - b}");
            Console.WriteLine($"Mutiply: {a * b}");
            Console.WriteLine($"Divide: {a / b}");
            Console.WriteLine($"Modulus: {a % b}\n");
        }

        public void IfElseTask()
        {
            int number;

            Console.Write("Enter your Age: ");
            var eligibleAge = Console.ReadLine();

            if(int.TryParse(eligibleAge, out number))
            {
                if (number >= 18)
                {
                    Console.WriteLine("You are eligible in vote\n");
                }
                else
                {
                    Console.WriteLine($"You are not eligible because your age is: {number}\n");
                }
            }
            else
            {
                Console.WriteLine($"You entered: {eligibleAge}. Please enter the number only\n");
            }
        }

        public void SwitchTask()
        {
            int number;
            Console.Write("Enter a input showing all week days : ");
            var day = Console.ReadLine();

            if(int.TryParse(day, out number))
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine($"{day} : is a Monday.\n");
                        break;
                    case 2:
                        Console.WriteLine($"{day} : is a Tuesday.\n");
                        break;
                    case 3:
                        Console.WriteLine($"{day} : is a Wednesday.\n");
                        break;
                    case 4:
                        Console.WriteLine($"{day} : is a Thursday.\n");
                        break;
                    case 5:
                        Console.WriteLine($"{day} : is a Friday.\n");
                        break;
                    case 6:
                        Console.WriteLine($"{day} : is a Saturday.\n");
                        break;
                    case 7:
                        Console.WriteLine($"{day} : is a Sunday.\n");
                        break;
                    default:
                        Console.WriteLine($"You entered wrong input = {day}. Please try this number only (1 to 7).");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"You entered: {day}. Please try this number only (1 to 7).\n");
            }
        }

        public void ForLoopTask()
        {
            for (int i=0; i<10; i++)
            {
                Console.WriteLine(i + "\n");
            }
        }

        public void WhileLoopTask()
        {
            int number = 0;

            while(number <= 20)
            {                
                if(number % 2 == 0)
                {
                    Console.WriteLine(number);                    
                }
                number++;
            }
        }

        public void ArrayTask()
        {
            Console.WriteLine("\n");

            string[] names =
            {
                "Arun",
                "Kumar",
                "Raj",
                "Ajay",
                "Vijay",
            };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        // Method to add two numbers and return the sum
        public int AddNumbers(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
            return sum;
        }
    }

    public class Student
    {
        string Name { get; set; }
        int Age { get; set; }
        string Department { get; set; }

        public Student(string name, int age, string department)
        {
            Name = name;
            Age = age;
            Department = department;
        }

        public void StudentDetails()
        {
            Console.WriteLine($"Student Name: {Name}\nStudent Age: {Age}\nStudent Department: {Department}");
        }
    }
}
