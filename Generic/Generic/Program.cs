using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Program");

            FindMaximum findMaximum = new FindMaximum();
            //Console.WriteLine(findMaximum.MaximumIntegerNum(98, 150, 88));
            //Console.WriteLine(findMaximum.MaximumFloatNum(5.678, 8.997, 12.145));
            Console.WriteLine(findMaximum.MaximumString("50", "40", "35"));


        }
    }
}