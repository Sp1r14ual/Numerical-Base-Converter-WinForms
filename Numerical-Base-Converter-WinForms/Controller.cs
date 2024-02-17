using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Base_Converter_WinForms
{
    internal class Controller
    {
        private int pin = 10;

        private int pout = 16;

        private const int accuracy = 10;

        public History his = new History();

        public enum State
        {
            Editing,
            Converted
        }
        public State St { get; set; }

        public Controller(int pin, int pout)
        {
            St = State.Editing;
            Pin = pin;
            Pout = pout;
        }

        public Editor ed = new Editor();
        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public int Pout
        {
            get { return pout; }
            set { pout = value; }
        }

        public string DoCmnd(string j)
        {
            if (j == "GO")
            {
                double r;
                if (pin != 10)
                    r = Convert_P_10.dval(ed.Number, (Int16)Pin);
                else
                    if (j.Contains('.'))
                        r = double.Parse(ed.Number, CultureInfo.InvariantCulture);
                    else
                        r = int.Parse(ed.Number, CultureInfo.InvariantCulture);

                string res = Convert_10_P.Do(r, (Int32)Pout, acc());
                St = State.Converted;
                his.AddRecord(Pin, Pout, ed.Number, res);
                return res;
            }
            else
            {
                St = State.Editing;
                return ed.DoEdit(j);
            }
        }

        private int acc()
        {
            return (int)Math.Round(ed.Acc() * Math.Log(Pin) / Math.Log(Pout) + 0.5);
        }
    }
}
