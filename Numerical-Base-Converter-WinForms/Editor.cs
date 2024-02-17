using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Base_Converter_WinForms
{
    internal class Editor
    {
        private string number = String.Empty;

        private const string delim = ".";

        private const string zero = "0";
        public string Number
        {
            //Почему просто get; не работает???
            get
            {
                return number;
            }
        }
        public string? AddDigit(string n)
        {
            this.number += n;
            return Number;
        }
        public int Acc()
        {
            return this.number.Substring(this.number.IndexOf('.') + 1).Length;
        }
        public string? AddZero()
        {
            this.number += zero;
            return Number;
        }
        public string? AddDelim()
        {
            this.number += delim;
            return Number;
        }
        public string? Bs()
        {
            try
            {
                this.number = this.number.Substring(0, this.number.Length - 1);
            }
            catch
            {
                this.number = String.Empty;
            }

            return Number;
        }
        public string? Clear()
        {
            this.number = String.Empty;
            return Number;
        }
        public string DoEdit(string j)
        {
            switch (j)
            {
                case "0":
                    AddZero();
                    break;
                case "1":
                    AddDigit("1");
                    break;
                case "2":
                    AddDigit("2");
                    break;
                case "3":
                    AddDigit("3");
                    break;
                case "4":
                    AddDigit("4");
                    break;
                case "5":
                    AddDigit("5");
                    break;
                case "6":
                    AddDigit("6");
                    break;
                case "7":
                    AddDigit("7");
                    break;
                case "8":
                    AddDigit("8");
                    break;
                case "9":
                    AddDigit("9");
                    break;
                case "A":
                    AddDigit("A");
                    break;
                case "B":
                    AddDigit("B");
                    break;
                case "C":
                    AddDigit("C");
                    break;
                case "D":
                    AddDigit("D");
                    break;
                case "E":
                    AddDigit("E");
                    break;
                case "F":
                    AddDigit("F");
                    break;
                case ".":
                    AddDelim();
                    break;
                case "BS":
                    Bs();
                    break;
                case "CLR":
                    Clear();
                    break;
                default:
                    break;
            }
            return Number;
        }
    }
}
