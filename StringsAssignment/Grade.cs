using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssignment
{
    internal class Grade
    {
        public static int[] marks;
        public static int total;

        public static int totl()
        {
            int totl = 0;
            foreach(int k in marks)
            {
                totl += k;

            }
            total = totl;
            return total;   
        }
        public static string Main()
        {
            if (total >= 700)
                return "A+";
            else if (total >= 600)
                return "A";
            else
                return "B";

        }


    }

}
