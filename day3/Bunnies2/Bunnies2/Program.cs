using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies2
{
    class Program
    {
        public static int BunnyEars(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n % 2 == 0 )
            {
                return 3 + BunnyEars(n - 1);
            }
            else
            {
                return 2 + BunnyEars(n - 1);
            }    
        }

        static void Main(string[] args)
        {
            Console.WriteLine(BunnyEars(3));
            Console.ReadLine();
        }
    }
}
