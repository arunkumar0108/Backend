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
    }
}
