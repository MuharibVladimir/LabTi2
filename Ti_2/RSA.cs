using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti_2
{
    public class RSA
    {
        public long p, q, r, e, d;

        public RSA(bool isUserInput, long pUser, long qUser, long eUser)
        {
            Initialize(isUserInput, pUser, qUser, eUser);
        }

        private void Initialize(bool isUserInput, long pUser, long qUser, long eUser)
        {
            if (isUserInput)
            {
                if (Keys.IsPrime(pUser) && Keys.IsPrime(qUser))
                {
                    p = pUser;
                    q = qUser;
                }
                else
                    throw new ArgumentException("Invalid RSA parameters");
            }
            else
            {
                p = Keys.Generate();
                q = Keys.Generate();
            }

            r = p * q;
            var fi = (p - 1) * (q - 1);

            e = isUserInput ? eUser : GetPublicPartKey(fi);
            d = GetPrivatePartKey(e, fi);
        }

        private long GetPublicPartKey(long fi)
        {
            long e = fi - 1;

            while (true)
            {
                if (Keys.IsPrime(e) && e < fi &&
                    BigInteger.GreatestCommonDivisor(new BigInteger(e), new BigInteger(fi)) == BigInteger.One)
                    break;

                --e;
            }

            return e;
        }

        private long GetPrivatePartKey(long e, long fi)
        {
            long x, y, d;
            d = EuclidAdvanced(e, fi, out x, out y);

            if (d != 1)
                return -1;

            if (x < 0)
                x += e;

            return (x < 0) ? MultiplicateInverse(fi, e) : x;
        }

        public string Encrypt(string plaintText, long e, long r)
        {
            if (d == -1)
                return "Error";

            string cipherText = String.Empty;
            BigInteger number;

            foreach (var ch in plaintText)
            {
                int index = ch;
                number = FastExp(index, e, r);
                cipherText += number.ToString() + ' ';
            }

            return cipherText;
        }

        public string Decrypt(string[] cipherText, long d, long r)
        {
            string plainText = String.Empty;
            BigInteger number;

            foreach (var item in cipherText)
            {
                var value = new BigInteger(Convert.ToInt64(item));
                number = FastExp(value, d, r);
                plainText += (char)number;
            }

            return plainText;
        }

        private BigInteger FastExp(BigInteger a, BigInteger z, BigInteger n)
        {
            BigInteger a1 = a, z1 = z, x = 1;
            while (z1 != 0)
            {
                while (z1 % 2 == 0)
                {
                    z1 = z1 / 2;
                    a1 = (a1 * a1) % n;
                }

                z1 = z1 - 1;
                x = (x * a1) % n;
            }

            return x;
        }

        private long EuclidAdvanced(long a, long b, out long x, out long y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            long x1, y1;
            long d = EuclidAdvanced(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

        private long MultiplicateInverse(long fi, long e)
        {
            long d = e + 1;

            while (true)
            {
                if ((d * e) % fi == 1)
                    break;
                d++;
            }

            return d;
        }
    }
}
