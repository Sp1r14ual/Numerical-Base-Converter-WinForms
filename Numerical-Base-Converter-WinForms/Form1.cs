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
                MessageBox.Show("Число уже содержит разделитель целой и дробной части", "Ошибка", MessageBoxButtons.OK,
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
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBox2.Text = controller.DoCmnd("GO");
            listBox1.Items.Add(controller.his.GetLastRecord());
        }

        private void button21_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = controller.DoCmnd("SGN");
            }
            catch
            {
                MessageBox.Show("Сначала введите число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
