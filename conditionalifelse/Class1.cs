using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalifelse
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year");

            int year = Convert.ToInt32(Console.ReadLine());
            if(year%4==0)
            {
                Console.WriteLine(" Leap Year");
            }
            else
            {
                Console.WriteLine(" Not Leap Year");
            }
        }

    }
}
