using System.Collections.Generic;
using System.Text;

namespace Backend
{
    public class PracticeMethodTypes
    {
        public void StringTypePractice()
        {
            string trim = "  CSharp  ";
            Console.WriteLine(trim.Trim());

            string upperCase = "developer";
            Console.WriteLine(upperCase.ToUpper());

            string split = "red,green,blue";
            string[] splittedOne = split.Split(',');
            string[] splittedTwo = split.Split(',');
            string[] splittedThree = split.Split(',');
            Console.WriteLine(splittedOne[0]);
            Console.WriteLine(splittedOne[1]);
            Console.WriteLine(splittedOne[2]);

            string replace = "I like dog";
            Console.WriteLine(replace.Replace("dog", "cat"));

            string length = "Programming";
            Console.WriteLine(length.Length);

            Console.ReadLine();
        }
    }
}
