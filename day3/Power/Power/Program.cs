using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        public static int PowerN(int num, int n)
        {
            if (n != 0 && num != 0)
            {
                num * PowerN(num, n - 1);
            }
            return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PowerN(3, 5));
            Console.ReadLine();
        }
    }
}
