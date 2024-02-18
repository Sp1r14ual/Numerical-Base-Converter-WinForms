namespace Numerical_Base_Converter_WinForms
{
    public partial class Form1 : Form
    {
        private Controller controller = new Controller(10, 16);
        public Form1()
        {
            InitializeComponent();
        }

        private bool check_input()
        {
            string input = textBox1.Text;
            int p = controller.Pin;

            if (input == String.Empty)
                return true;

            foreach (var c in input)
            {
                if (c == 'F' && p < 16)
                    return true;
                if (c == 'E' && p < 15)
                    return true;
                if (c == 'D' && p < 14)
                    return true;
                if (c == 'C' && p < 13)
                    return true;
                if (c == 'B' && p < 12)
                    return true;
                if (c == 'A' && p < 11)
                    return true;
                if (c == '9' && p < 10)
                    return true;
                if (c == '8' && p < 9)
                    return true;
                if (c == '7' && p < 8)
                    return true;
                if (c == '6' && p < 7)
                    return true;
                if (c == '5' && p < 6)
                    return true;
                if (c == '4' && p < 5)
                    return true;
                if (c == '3' && p < 4)
                    return true;
                if (c == '2' && p < 3)
                    return true;
            }

            return false;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int value = trackBar1.Value;
            numericUpDown1.Value = value;
            controller.Pin = value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown1.Value;
            trackBar1.Value = Convert.ToInt32(value);
            controller.Pin = Convert.ToInt32(value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int value = trackBar2.Value;
            numericUpDown2.Value = value;
            controller.Pout = value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown2.Value;
            trackBar2.Value = Convert.ToInt32(value);
            controller.Pout = Convert.ToInt32(value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("A");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("B");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("C");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("D");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("E");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("F");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('.'))
            {
                MessageBox.Show("����� ��� �������� ����������� ����� � ������� �����", "������", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (textBox1.Text == String.Empty)
            {
                textBox1.Text = controller.DoCmnd("0");
                textBox1.Text = controller.DoCmnd(".");
                return;
            }

            textBox1.Text = controller.DoCmnd(".");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("BS");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = controller.DoCmnd("CLR");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (check_input())
            {
                MessageBox.Show("�������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBox2.Text = controller.DoCmnd("GO");
            //listBox1.Items.Add(controller.his.GetLastRecord());
            Record lastCalc = controller.his.GetLastRecord();
            dataGridView1.Rows.Add(new string[] { lastCalc.P1, lastCalc.N1, lastCalc.P2, lastCalc.N2 });
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            dataGridView1.Rows.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = controller.DoCmnd("SGN");
            }
            catch
            {
                MessageBox.Show("������� ������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            List<string> symbols = new List<string>() {"D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9",
                "A", "B", "C", "D", "E", "F", "Oemcomma", "OemPeriod", "Oem2", "Back", "Delete", "Enter",
                "NumPad0", "NumPad1", "NumPad2", "NumPad3", "NumPad4", "NumPad5", "NumPad6", "NumPad7", "NumPad8", "NumPad9",
                "Oemplus", "OemMinus"
            };

            var sym = e.KeyCode.ToString();

            if (!(symbols.Contains(sym)))
                return;

            switch (sym)
            {
                case "D0":
                case "NumPad0":
                    textBox1.Text = controller.DoCmnd("0");
                    break;
                case "D1":
                case "NumPad1":
                    textBox1.Text = controller.DoCmnd("1");
                    break;
                case "D2":
                case "NumPad2":
                    textBox1.Text = controller.DoCmnd("2");
                    break;
                case "D3":
                case "NumPad3":
                    textBox1.Text = controller.DoCmnd("3");
                    break;
                case "D4":
                case "NumPad4":
                    textBox1.Text = controller.DoCmnd("4");
                    break;
                case "D5":
                case "NumPad5":
                    textBox1.Text = controller.DoCmnd("5");
                    break;
                case "D6":
                case "NumPad6":
                    textBox1.Text = controller.DoCmnd("6");
                    break;
                case "D7":
                case "NumPad7":
                    textBox1.Text = controller.DoCmnd("7");
                    break;
                case "D8":
                case "NumPad8":
                    textBox1.Text = controller.DoCmnd("8");
                    break;
                case "D9":
                case "NumPad9":
                    textBox1.Text = controller.DoCmnd("9");
                    break;
                case "A":
                    textBox1.Text = controller.DoCmnd("A");
                    break;
                case "B":
                    textBox1.Text = controller.DoCmnd("B");
                    break;
                case "C":
                    textBox1.Text = controller.DoCmnd("C");
                    break;
                case "D":
                    textBox1.Text = controller.DoCmnd("D");
                    break;
                case "E":
                    textBox1.Text = controller.DoCmnd("E");
                    break;
                case "F":
                    textBox1.Text = controller.DoCmnd("F");
                    break;
                case "Oemcomma":
                case "OemPeriod":
                case "Oem2":
                    if (textBox1.Text.Contains('.'))
                    {
                        MessageBox.Show("����� ��� �������� ����������� ����� � ������� �����", "������", 
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    if (textBox1.Text == String.Empty)
                    {
                        textBox1.Text = controller.DoCmnd("0");
                        textBox1.Text = controller.DoCmnd(".");
                        return;
                    }

                    textBox1.Text = controller.DoCmnd(".");
                    break;
                case "Back":
                    textBox1.Text = controller.DoCmnd("BS");
                    break;
                case "Delete":
                    textBox1.Text = controller.DoCmnd("CLR");
                    break;
                case "Enter":
                    if (check_input())
                    {
                        MessageBox.Show("�������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    textBox2.Text = controller.DoCmnd("GO");
                    Record lastCalc = controller.his.GetLastRecord();
                    dataGridView1.Rows.Add(new string[] { lastCalc.P1, lastCalc.N1, lastCalc.P2, lastCalc.N2 });
                    break;
                case "Oemplus":
                case "OemMinus":
                    try
                    {
                        textBox1.Text = controller.DoCmnd("SGN");
                    }
                    catch
                    {
                        MessageBox.Show("������� ������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                default:
                    break;
            }
        }
    }
}
