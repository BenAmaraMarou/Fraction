using System;

namespace fraction_kata
{
    public class GeatestCommonDivisor
    {
        public static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return Math.Abs(a);
        }
    }
}
