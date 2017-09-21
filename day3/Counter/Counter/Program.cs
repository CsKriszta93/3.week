using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        public static int Counter(int n)
        {
            Console.WriteLine(n);
            if (n > 1)
            {
                return Counter(n - 1);
            }
            return 0;           
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Counter(6));
            Console.ReadLine();
        }
    }
}
