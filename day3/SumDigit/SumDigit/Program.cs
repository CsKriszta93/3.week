using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigit
{
    class Program
    {
        public static int DigitSum(int n)
        {
            if (n != 0)
            {
                return n % 10 + DigitSum(n / 10); 
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DigitSum(123));
            Console.ReadLine();
        }
    }
}
