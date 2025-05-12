using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Problem2
    {
        public static void Main(string[] args)
        {
            int dividend = 9;
            int divisor = 3;
            int result = Divide(dividend, divisor);
            Console.WriteLine("This is result: ");
            Console.WriteLine(result);
        }

        static int Divide(int dividend, int divisor)
        {
            int count = 0;
            while (dividend >= divisor)
            {
                dividend -= divisor;
                count += 1;
            }
            return count;
        }
    }

}
