using System;
using System.Collections.Generic;
using System.Text;

namespace Backend
{
    static class StaticClassMathPractice
    {
        public static int MathAdd(int a, int b)
        {
            return (a + b);
        }
        public static int MathMultiply(int a, int b)
        {
            return (a + b);
        }
        public static int MathDivide(int a, int b)
        {
            return (a + b);
        }

        public static T GenericsExample<T>(T a, T b)
        {
            if (a.Equals(b))
            {
                Console.WriteLine("Both are equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

            return a;
        }
    }
}
