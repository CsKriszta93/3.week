using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny1
{
    class Program
    {
        public static int BunnyEars(int n)
        {
            if (n != 0)
            {
                return 2 + BunnyEars(n - 1);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(BunnyEars(159));
            Console.ReadLine();
        }
    }
}
