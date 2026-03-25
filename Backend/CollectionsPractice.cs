using System;
using System.Collections;
using System.Text;
using Backend.Helper;

namespace Backend
{
    public class CollectionsPractice
    {
        public void ArrayPractice()
        {
            // Interger Array Practice
            int[] arrayInt = new int[5];
            arrayInt[0] = 1;
            arrayInt[1] = 2;
            arrayInt[2] = 3;
            arrayInt[3] = 4;
            arrayInt[4] = 5;

            Console.WriteLine("Array integer values:");

            foreach (int array in arrayInt)
            {
                Console.WriteLine("Array: " + array);
            }

            // String Array Practice
            string[] arrayString = new string[5];
            arrayString[0] = "Jack";
            arrayString[1] = "Jill";
            arrayString[2] = "John";
            arrayString[3] = "Jane";
            arrayString[4] = "Doe";

            Console.WriteLine("Array string values:");

            foreach (string array in arrayString)
            {
                Console.WriteLine("Array: " + array);
            }
        }

        public void ArrayListPractice()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Jack");
            arrayList.Add(3.345);
            arrayList.Add(true);

            Console.WriteLine("ArrayList values:");

            foreach (var arrayLists in arrayList)
            {
                Console.WriteLine(arrayLists);
            }
        }

        public List<EmployeeDetailsForList> ListPractice()
        {
            List<EmployeeDetailsForList> rvsEmployeelist = new List<EmployeeDetailsForList>();

            rvsEmployeelist.Add(
                new EmployeeDetailsForList
                {
                    Name = "Jack",
                    Designation = "Software Engineer",
                    Age = 30,
                    Company = "Royal Value Solutions",
                }
            );
            rvsEmployeelist.Add(
                new EmployeeDetailsForList
                {
                    Name = "Jim",
                    Designation = "Web Engineer",
                    Age = 30,
                    Company = "Royal Value Solutions",
                }
            );
            rvsEmployeelist.Add(
                new EmployeeDetailsForList
                {
                    Name = "Kuhn",
                    Designation = "Tester Engineer",
                    Age = 30,
                    Company = "Royal Value Solutions",
                }
            );
            rvsEmployeelist.Add(
                new EmployeeDetailsForList
                {
                    Name = "John",
                    Designation = "Production Engineer",
                    Age = 30,
                    Company = "Royal Value Solutions",
                }
            );

            return rvsEmployeelist;
        }

        public Dictionary<string, EmployeeDetailsForDictionary> DictionaryPractice()
        {
            Dictionary<string, EmployeeDetailsForDictionary> rvsEmployeeDictionary =
                new Dictionary<string, EmployeeDetailsForDictionary>();

            rvsEmployeeDictionary.Add(
                "DICT9001",
                new EmployeeDetailsForDictionary
                {
                    Username = "Jack",
                    Password = "Jack123",
                    Email = "jack123@gmail.com",
                    RegisterNumber = 83226821,
                }
            );
            rvsEmployeeDictionary.Add(
                "DICT9002",
                new EmployeeDetailsForDictionary
                {
                    Username = "Jim",
                    Password = "Jim123",
                    Email = "jim123@gmail.com",
                    RegisterNumber = 633226821,
                }
            );
            rvsEmployeeDictionary.Add(
                "DICT9003",
                new EmployeeDetailsForDictionary
                {
                    Username = "John",
                    Password = "John123",
                    Email = "john123@gmail.com",
                    RegisterNumber = 75333226821,
                }
            );
            rvsEmployeeDictionary.Add(
                "DICT9004",
                new EmployeeDetailsForDictionary
                {
                    Username = "Rosy",
                    Password = "Rosy123",
                    Email = "rosy123@gmail.com",
                    RegisterNumber = 8333226821,
                }
            );
            rvsEmployeeDictionary.Add(
                "DICT9005",
                new EmployeeDetailsForDictionary
                {
                    Username = "Kuhn",
                    Password = "Kuhn123",
                    Email = "kuhn123@gmail.com",
                    RegisterNumber = 5333226821,
                }
            );

            return rvsEmployeeDictionary;
        }
    }
}
