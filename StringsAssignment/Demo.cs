using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssignment
{
    internal class Demo
    {
        private int a;
        public void Message()
        {
            Console.WriteLine("welcome to dot net");
            Console.WriteLine("A=" + a);

        }
        public void Seta()
        {
            a = 10;

        }
        public void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        public void Add(int a, int b)
        {
            int c;
            c = a + b;
            Console.WriteLine("Addition: " + c);
        }
        public static void Main(string[] args)
        {
            Demo d = new Demo();
            d.Message();
            d.Seta();
            d.Greet("HAI");
            d.Add(1, 2);

        }

    }   
}
