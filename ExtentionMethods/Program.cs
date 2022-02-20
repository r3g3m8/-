using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Изменения 1
            DateTime currentDateTime = DateTime.Now;
            currentDateTime.Print();
            DateTime.Now.Print();
        }
    }
}
