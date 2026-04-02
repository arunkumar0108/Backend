using Backend.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend
{
    public class LinqPractice
    {
        public void LinqMethodPractice()
        {
            var rvsEmployeeDetails = new HashSet<EmployeeDetailsForIEnumerable>();

            rvsEmployeeDetails.Add(new EmployeeDetailsForIEnumerable
            {
                Name = "Jack",
                Id = 2324,
                Age = 25
            });
            rvsEmployeeDetails.Add(new EmployeeDetailsForIEnumerable
            {
                Name = "Jai",
                Id = 2325,
                Age = 20
            });
            rvsEmployeeDetails.Add(new EmployeeDetailsForIEnumerable
            {
                Name = "Arun",
                Id = 2326,
                Age = 22
            });
            rvsEmployeeDetails.Add(new EmployeeDetailsForIEnumerable
            {
                Name = "John",
                Id = 2327,
                Age = 21
            });

            var filterAgeBy = rvsEmployeeDetails.Where(x => x.Age > 20).ToList();

            foreach (var filter in filterAgeBy)
            {
                Console.WriteLine($"Name: {filter.Name} | Id: {filter.Id} | Age: {filter.Age}");
            }
        }

        public void LinqWithThenByPractice()
        {
            List<EmployeeDetailsForIEnumerable> employeeSortThenby = new List<EmployeeDetailsForIEnumerable>();

            employeeSortThenby.Add(new EmployeeDetailsForIEnumerable
            {
                Name = "Arun",
                Id = 2326,
                Age= 25
            });
            employeeSortThenby.Add(new EmployeeDetailsForIEnumerable
            {
                Name = "Jai",
                Id = 2325,
                Age = 24
            });
            employeeSortThenby.Add(new EmployeeDetailsForIEnumerable
            {
                Name = "ArunJim",
                Id = 2324,
                Age = 26
            });

            Console.WriteLine("Employees showing like ThenBy Ascending: ");

            var ascending = employeeSortThenby.OrderBy(x => x.Id).ThenBy(x => x.Name);

            foreach(var result1 in ascending)
            {
                Console.WriteLine($"Id: {result1.Id} | Name: {result1.Name}");
            }

            Console.WriteLine("\nEmployees showing like ThenBy Descending: ");

            var descending = employeeSortThenby.OrderByDescending(x => x.Id).ThenByDescending(x => x.Name);

            foreach(var result2 in descending)
            {
                Console.WriteLine($"Id: {result2.Id} | Name: {result2.Name}");
            }
        }
    }
}
