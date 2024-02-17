namespace Numerical_Base_Converter_WinForms
{
    public partial class Form1 : Form
    {
        private Controller controller = new Controller(10, 16);
        public Form1()
        {
            InitializeComponent();
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
            textBox2.Text = controller.DoCmnd("GO");
        }
    }
}
