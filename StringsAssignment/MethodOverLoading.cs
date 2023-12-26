using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssignment
{
    internal class MethodOverLoading
    {
        static void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);

        }
        static void add(int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine(d);

        }
        static void add (double a, double b)
        {
            double c = a + b;
            Console.WriteLine(c);
        }
        public static void Main()
        {
            add(1, 2);
            add(2, 3, 4);
            add(3.5, 4.2);
        }
    }
}
