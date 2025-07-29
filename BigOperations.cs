using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _4lr
{
    static class BigOperations
    {
        public static BigInteger Sqrt(this BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!isSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }

        public static Boolean isSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound && n < upperBound);
        }

        public static string ConvertToBinary(BigInteger number)
        {
            if (number == 0)
                return "0";

            string binary = "";
            while (number > 0)
            {
                binary = (number % 2) + binary;
                number /= 2;
            }
            return binary;
        }

        public static BigInteger BinaryConvertToBigInteger(string binaryString)
        {   
            BigInteger result = 0;
            foreach (char bit in binaryString)
            {
                result = result * 2 + (bit == '1' ? 1 : 0);
            }
            return result;
        }

        public static BigInteger HexConvertToBigInteger(string hexadecimalString, int baseValue)
        {
            BigInteger result = 0;
            foreach (char digit in hexadecimalString)
            {
                int digitValue;
                if (Char.IsDigit(digit))
                    digitValue = digit - '0';
                else
                    digitValue = char.ToUpper(digit) - 'A' + 10;
                result = result * baseValue + digitValue;
            }
            return result;
        }
    }
}
