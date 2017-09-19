using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividebyZero
{
    class Program
    {
        public static double Divide(int input)
        {
            double result = 10 / input;
            if (input == 0)
            {
                Console.WriteLine("fail");
            }
            return result;
        }

        static void Main(string[] args)
        {
            // create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // it should print "fail" if the parameter is 0
            Console.WriteLine(Divide(5));
            Console.ReadLine();
        }
    }
    
}
