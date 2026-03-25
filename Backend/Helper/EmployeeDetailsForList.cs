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
}
