using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    static class MyExtention
    {
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }
    }
}
