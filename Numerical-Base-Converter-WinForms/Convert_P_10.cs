using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Base_Converter_WinForms
{
    internal class Convert_P_10
    {
        static double char_To_Num(char ch)
        {
            switch (ch)
            {
                case 'A':
                    return 10;
                case 'B':
                    return 11;
                case 'C':
                    return 12;
                case 'D':
                    return 13;
                case 'E':
                    return 14;
                case 'F':
                    return 15;
                default:
                    return ch - '0';
            }
        }

        public static double dval(string P_num, int P)
        {
            int decimalPointIndex = P_num.IndexOf('.');
            double integerPart = 0;
            double fractionPart = 0;
            bool isNegative = false;

            // Convert integer part
            if (decimalPointIndex != -1)
            {
                if (P_num[0] == '-')
                {
                    isNegative = true;
                    for (int i = 1; i < decimalPointIndex; i++)
                    {
                        double digit = char_To_Num(P_num[i]);
                        integerPart = integerPart * P + digit;
                    }
                }
                else
                    for (int i = 0; i < decimalPointIndex; i++)
                    {
                        double digit = char_To_Num(P_num[i]);
                        integerPart = integerPart * P + digit;
                    }
            }
            else
            {
                if (P_num[0] == '-')
                {
                    isNegative = true;
                    for (int i = 1; i < P_num.Length; i++)
                    {
                        double digit = char_To_Num(P_num[i]);
                        integerPart = integerPart * P + digit;
                    }
                }
                else
                    for (int i = 0; i < P_num.Length; i++)
                    {
                        double digit = char_To_Num(P_num[i]);
                        integerPart = integerPart * P + digit;
                    }
            }

            if (decimalPointIndex == -1)
                return isNegative ? -integerPart : integerPart;

            // Convert fraction part
            for (int i = decimalPointIndex + 1; i < P_num.Length; i++)
            {
                //int digit = Char.IsDigit(number[i]) ? number[i] - '0' : number[i] - 'A' + 10;
                double digit = char_To_Num(P_num[i]);
                fractionPart = fractionPart * P + digit;
            }
            fractionPart /= Math.Pow(P, P_num.Length - decimalPointIndex - 1);

            return isNegative ? -(integerPart + fractionPart) : integerPart + fractionPart;
        }
        private static double convert(string P_num, int P, double weight)
        {
            double result = 0;

            for (int i = 0; i < P_num.Length; i++)
            {
                double digit = char_To_Num(P_num[i]);
                result += digit * Math.Pow(P, P_num.Length - 1 - i);
            }

            double fractionPart = 0;
            for (int i = P_num.Length - 1; i >= 0; i--)
            {
                double digit = char_To_Num(P_num[i]);
                fractionPart = (fractionPart + digit) / P;
            }

            result += fractionPart * weight;
            return result;
        }
    }
}
