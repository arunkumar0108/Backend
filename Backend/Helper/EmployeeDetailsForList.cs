using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Helper
{
    public class EmployeeDetailsForList
    {
        public string? Name { get; set; }
        public string? Designation { get; set; }
        public int Age { get; set; }
        public string? Company { get; set; }
    }

    public class EmployeeDetailsForDictionary
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public long? RegisterNumber { get; set; }
    }
    public class EmployeeDetailsForIEnumerable
    {
        public string? Name { get; set; }
        public int? Id { get; set; }
        public int? Age { get; set; }
    }

    public class EmployeeDetailsForIQueryable
    {
        public List<EmployeeDetailsForIEnumerable> GetEmployees()
        {
            return new List<EmployeeDetailsForIEnumerable>
            {
                new EmployeeDetailsForIEnumerable { Name = "Jack", Age = 25, Id = 23 },
                new EmployeeDetailsForIEnumerable { Name = "John", Age = 30, Id = 23 },
                new EmployeeDetailsForIEnumerable { Name = "Arun", Age = 35, Id = 23 }
            };
        }
    }
}
