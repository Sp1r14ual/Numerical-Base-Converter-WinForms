namespace Numerical_Base_Converter_WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            trackBar1 = new TrackBar();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            label2 = new Label();
            trackBar2 = new TrackBar();
            numericUpDown2 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 39);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(439, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 83);
            label1.Name = "label1";
            label1.Size = new Size(348, 20);
            label1.TabIndex = 1;
            label1.Text = "Основание системы счисления исходного числа";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(216, 126);
            trackBar1.Maximum = 16;
            trackBar1.Minimum = 2;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(326, 56);
            trackBar1.TabIndex = 2;
            trackBar1.Value = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(564, 126);
            numericUpDown1.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(91, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 212);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(439, 27);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 254);
            label2.Name = "label2";
            label2.Size = new Size(306, 20);
            label2.TabIndex = 5;
            label2.Text = "Основание системы счисления результата";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(216, 289);
            trackBar2.Maximum = 16;
            trackBar2.Minimum = 2;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(326, 56);
            trackBar2.TabIndex = 6;
            trackBar2.Value = 16;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(564, 289);
            numericUpDown2.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(91, 27);
            numericUpDown2.TabIndex = 7;
            numericUpDown2.Value = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(324, 365);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 8;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(380, 365);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 9;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(436, 365);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 10;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(492, 365);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 11;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(324, 421);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 12;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(380, 421);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 13;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(436, 421);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 14;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(492, 421);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 15;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(324, 477);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 16;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(380, 477);
            button10.Name = "button10";
            button10.Size = new Size(50, 50);
            button10.TabIndex = 17;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(436, 477);
            button11.Name = "button11";
            button11.Size = new Size(50, 50);
            button11.TabIndex = 18;
            button11.Text = "A";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(492, 477);
            button12.Name = "button12";
            button12.Size = new Size(50, 50);
            button12.TabIndex = 19;
            button12.Text = "B";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(324, 531);
            button13.Name = "button13";
            button13.Size = new Size(50, 50);
            button13.TabIndex = 20;
            button13.Text = "C";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(380, 533);
            button14.Name = "button14";
            button14.Size = new Size(50, 50);
            button14.TabIndex = 21;
            button14.Text = "D";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(436, 531);
            button15.Name = "button15";
            button15.Size = new Size(50, 50);
            button15.TabIndex = 22;
            button15.Text = "E";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Location = new Point(492, 531);
            button16.Name = "button16";
            button16.Size = new Size(50, 50);
            button16.TabIndex = 23;
            button16.Text = "F";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Location = new Point(324, 587);
            button17.Name = "button17";
            button17.Size = new Size(50, 50);
            button17.TabIndex = 24;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Location = new Point(380, 587);
            button18.Name = "button18";
            button18.Size = new Size(50, 50);
            button18.TabIndex = 25;
            button18.Text = "BS";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.Location = new Point(436, 587);
            button19.Name = "button19";
            button19.Size = new Size(50, 50);
            button19.TabIndex = 26;
            button19.Text = "CLR";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.Location = new Point(492, 587);
            button20.Name = "button20";
            button20.Size = new Size(50, 50);
            button20.TabIndex = 27;
            button20.Text = "GO";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 696);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown2);
            Controls.Add(trackBar2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(trackBar1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Конвертер";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TrackBar trackBar1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private Label label2;
        private TrackBar trackBar2;
        private NumericUpDown numericUpDown2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
    }
}
