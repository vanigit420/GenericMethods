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

            //FindMaximum findMaximum = new FindMaximum();
            //Console.WriteLine(findMaximum.MaximumIntegerNum(98, 150, 88));
            //Console.WriteLine(findMaximum.MaximumFloatNum(5.678, 8.997, 12.145));
            //Console.WriteLine(findMaximum.MaximumString("50", "40", "35"));

            int[] array = { 110, 245, 655, 700, 585 };
            GenericMaximum<int> genericMaximum = new GenericMaximum<int>(array);
            genericMaximum.PrintMaxValue();

            double[] doubles = { 50.5, 43.789, 38.24, 95.45, 345.23 };
            GenericMaximum<double> genericMaximum1 = new GenericMaximum<double>(doubles);
            genericMaximum1.PrintMaxValue();

            string[] strings = { "111", "93", "655", "568", "990" };
            GenericMaximum<string> genericMaximum2 = new GenericMaximum<string>(strings);
            genericMaximum2.PrintMaxValue();

        }
    }
}