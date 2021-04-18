using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti_2
{
    internal static class Keys
    {
            private static Random _randomSelection = new Random();

            public static bool IsPrime(long n)
            {
                if (n == 1)
                    return false;

                for (int d = 2; d * d <= n; d++)
                    if (n % d == 0)
                        return false;

                return true;
            }

            public static long Generate()
            {
                var numbers = new List<long>();
                long left = 50, right = 150;

                while (left++ < right)
                {
                    if (IsPrime(left))
                        numbers.Add(left);
                }

                return numbers[_randomSelection.Next(0, numbers.Count)];
            }
        }
    
}
