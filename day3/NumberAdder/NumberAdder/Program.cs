using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAdder
{
    class Program
    {
        public static int AddNumber(int n)
        {
            if (n > 0)
            {
                return n += AddNumber(n - 1);
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AddNumber(3)); 
            Console.ReadLine();
        }
    }
}
