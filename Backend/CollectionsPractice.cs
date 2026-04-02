using Backend.Helper;
using System.Collections;

namespace Backend
{
    public class CollectionsPractice
    {

        EmployeeDetailsForIQueryable employeeDetailsForIQueryable = new EmployeeDetailsForIQueryable();
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
                    RegisterNumber = null,
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

        public void IEnumerablePractice()
        {
            List<EmployeeDetailsForIEnumerable> employees = new List<EmployeeDetailsForIEnumerable>
            {
                new EmployeeDetailsForIEnumerable { Id = 1, Name = "Jack", Age = 25 },
                new EmployeeDetailsForIEnumerable { Id = 2, Name = "John", Age = 30 },
                new EmployeeDetailsForIEnumerable { Id = 3, Name = "Arun", Age = 35 },
                new EmployeeDetailsForIEnumerable { Id = 4, Name = "Sam", Age = 28 }
            };

            // IEnumerable
            IEnumerable<EmployeeDetailsForIEnumerable> result = employees.Where(e => e.Age > 28);

            Console.WriteLine("IEnumerable Result:");

            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.Name} - {emp.Age}");
            }
        }

        public void IQueryablePractice()
        {
            IQueryable<EmployeeDetailsForIEnumerable> rvsEmployees = employeeDetailsForIQueryable.GetEmployees().AsQueryable();

            var employees = rvsEmployees.Where(e => e.Age > 25);

            Console.WriteLine("IQueryable Result:");

            foreach (var employee in employees)
            {
                Console.WriteLine($"Age above 25: {employee.Age}");
            }
        }

        public void HashsetPracctice()
        {
            List<string> duplicateList = new List<string>
            {
                "Jack", "Jack", "John", "John", "Jim", "Joyel", "Kuhn"
            };

            HashSet<string> filterUniquerValues = new HashSet<string>(duplicateList);

            foreach (var uniqueValue in filterUniquerValues)
            {
                Console.WriteLine(uniqueValue);
            }

            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);
            hashSet.Add(4);
            hashSet.Add(5);
            hashSet.Add(5);
            hashSet.Add(5);

            foreach (var uniqueValue in hashSet)
            {
                Console.WriteLine(uniqueValue);
            }

            // Fetch Duplicate values using Hashset
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };

            HashSet<int> uniques = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            Console.WriteLine("Fetching Duplicate values:");

            foreach (var num in numbers)
            {
                if (!uniques.Add(num))
                {
                    duplicates.Add(num);
                }
            }

            // Add Duplicate values to Hashset and print
            foreach (var duplicate in duplicates)
            {
                Console.WriteLine(duplicate);
            }
        }

    }
}
