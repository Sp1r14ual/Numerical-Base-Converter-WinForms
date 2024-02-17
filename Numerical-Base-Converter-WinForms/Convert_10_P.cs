using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Base_Converter_WinForms
{
    internal class Convert_10_P
    {
        public static char int_to_Char(int n)
        {
            switch (n)
            {
                case 10:
                    return 'A';
                case 11:
                    return 'B';
                case 12:
                    return 'C';
                case 13:
                    return 'D';
                case 14:
                    return 'E';
                case 15:
                    return 'F';
                default:
                    return (char)(n + 48);
            }
        }

        public static string int_to_P(int n, int p)
        {
            if (p < 2 || p > 16)
                throw new ArgumentException("Base must be between 2 and 16.");

            string result = "";

            while (n > 0)
            {
                int digit = n % p;
                result = int_to_Char(digit) + result;
                n /= p;
            }

            return result;
        }

        public static string flt_to_P(double n, int p, int c)
        {
            if (p < 2 || p > 16)
                throw new ArgumentException("Base must be between 2 and 16.");

            int integerPart = (int)n;
            double fractionalPart = n - integerPart;
            string integerPartStr = int_to_P(integerPart, p);

            if (c <= 0)
                return integerPartStr;

            string fractionalPartStr = ".";
            while (c > 0 && fractionalPart != 0)
            {
                fractionalPart *= p;
                int digit = (int)fractionalPart;
                fractionalPart -= digit;
                //???
                fractionalPartStr += int_to_Char(digit);
                c--;
            }

            return integerPartStr + fractionalPartStr;
        }

        public static string Do(object n, int p, int c)
        {
            bool isNegative = false;

            if (n is int || n is long)
            {
                int integerNumber = Convert.ToInt32(n);
                if (integerNumber < 0)
                {
                    integerNumber = Math.Abs(integerNumber);
                    isNegative = true;
                }

                string result = int_to_P(integerNumber, p);
                return isNegative ? '-' + result : result;
            }
            else if (n is float || n is double)
            {
                float floatNumber = Convert.ToSingle(n);

                if (floatNumber < 0)
                {
                    floatNumber = Math.Abs(floatNumber);
                    isNegative = true;
                }

                string result = flt_to_P(floatNumber, p, c);
                return isNegative ? '-' + result : result;
            }
            else
            {
                throw new ArgumentException("Unsupported type. Must be int, long, float or double.");
            }
        }
    }
}
