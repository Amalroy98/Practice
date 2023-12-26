using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssignment
{
    internal class Staff
    {
        public int staffid;
        public string staffname;

        public static string schoolname;
        public static string branch;

        public const string city = "Hyderbad";

        public string Display()
        {
            return $"Id: {staffid} name: {staffname} school: {schoolname} branch: {branch} city: {city}";
        }
        static void Main()
        {
            //access static data
            Staff.schoolname = "DPS";
            Staff.branch = "jubilishhill";

        }
    }
}
