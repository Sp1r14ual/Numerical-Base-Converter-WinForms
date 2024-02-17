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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button21 = new Button();
            label3 = new Label();
            listBox1 = new ListBox();
            tabPage3 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 59);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(439, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(57, 12);
            label1.Name = "label1";
            label1.Size = new Size(412, 23);
            label1.TabIndex = 1;
            label1.Text = "Основание системы счисления исходного числа";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(44, 115);
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
            numericUpDown1.Location = new Point(392, 115);
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
            textBox2.Location = new Point(44, 269);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(439, 27);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(84, 221);
            label2.Name = "label2";
            label2.Size = new Size(362, 23);
            label2.TabIndex = 5;
            label2.Text = "Основание системы счисления результата";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(44, 316);
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
            numericUpDown2.Location = new Point(392, 316);
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
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(152, 443);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 8;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(208, 443);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 9;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = SystemColors.HighlightText;
            button3.Location = new Point(264, 443);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 10;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.ForeColor = SystemColors.HighlightText;
            button4.Location = new Point(320, 443);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 11;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Blue;
            button5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button5.ForeColor = SystemColors.HighlightText;
            button5.Location = new Point(152, 499);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 12;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Blue;
            button6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button6.ForeColor = SystemColors.HighlightText;
            button6.Location = new Point(208, 499);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 13;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Blue;
            button7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button7.ForeColor = SystemColors.HighlightText;
            button7.Location = new Point(264, 499);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 14;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Blue;
            button8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button8.ForeColor = SystemColors.HighlightText;
            button8.Location = new Point(320, 499);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 15;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Blue;
            button9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button9.ForeColor = SystemColors.HighlightText;
            button9.Location = new Point(152, 555);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 16;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Blue;
            button10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button10.ForeColor = SystemColors.HighlightText;
            button10.Location = new Point(208, 555);
            button10.Name = "button10";
            button10.Size = new Size(50, 50);
            button10.TabIndex = 17;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Blue;
            button11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button11.ForeColor = SystemColors.HighlightText;
            button11.Location = new Point(264, 555);
            button11.Name = "button11";
            button11.Size = new Size(50, 50);
            button11.TabIndex = 18;
            button11.Text = "A";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Blue;
            button12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button12.ForeColor = SystemColors.HighlightText;
            button12.Location = new Point(320, 555);
            button12.Name = "button12";
            button12.Size = new Size(50, 50);
            button12.TabIndex = 19;
            button12.Text = "B";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Blue;
            button13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button13.ForeColor = SystemColors.HighlightText;
            button13.Location = new Point(152, 611);
            button13.Name = "button13";
            button13.Size = new Size(50, 50);
            button13.TabIndex = 20;
            button13.Text = "C";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Blue;
            button14.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button14.ForeColor = SystemColors.HighlightText;
            button14.Location = new Point(208, 611);
            button14.Name = "button14";
            button14.Size = new Size(50, 50);
            button14.TabIndex = 21;
            button14.Text = "D";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.Blue;
            button15.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button15.ForeColor = SystemColors.HighlightText;
            button15.Location = new Point(264, 611);
            button15.Name = "button15";
            button15.Size = new Size(50, 50);
            button15.TabIndex = 22;
            button15.Text = "E";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.Blue;
            button16.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button16.ForeColor = SystemColors.HighlightText;
            button16.Location = new Point(320, 611);
            button16.Name = "button16";
            button16.Size = new Size(50, 50);
            button16.TabIndex = 23;
            button16.Text = "F";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.Blue;
            button17.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button17.ForeColor = SystemColors.HighlightText;
            button17.Location = new Point(152, 667);
            button17.Name = "button17";
            button17.Size = new Size(50, 50);
            button17.TabIndex = 24;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.Red;
            button18.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button18.ForeColor = SystemColors.HighlightText;
            button18.Location = new Point(208, 667);
            button18.Name = "button18";
            button18.Size = new Size(50, 50);
            button18.TabIndex = 25;
            button18.Text = "BS";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.Red;
            button19.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button19.ForeColor = SystemColors.HighlightText;
            button19.Location = new Point(264, 667);
            button19.Name = "button19";
            button19.Size = new Size(50, 50);
            button19.TabIndex = 26;
            button19.Text = "CLR";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.LimeGreen;
            button20.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button20.ForeColor = SystemColors.HighlightText;
            button20.Location = new Point(320, 667);
            button20.Name = "button20";
            button20.Size = new Size(50, 50);
            button20.TabIndex = 27;
            button20.Text = "GO";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(568, 782);
            tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button20);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button19);
            tabPage1.Controls.Add(trackBar1);
            tabPage1.Controls.Add(button18);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(button17);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(button16);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button15);
            tabPage1.Controls.Add(trackBar2);
            tabPage1.Controls.Add(button14);
            tabPage1.Controls.Add(numericUpDown2);
            tabPage1.Controls.Add(button13);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button12);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button11);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button10);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button9);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button8);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button7);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(560, 749);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Конвертер";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button21);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(listBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(560, 749);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "История";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.BackColor = Color.Red;
            button21.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button21.ForeColor = SystemColors.HighlightText;
            button21.Location = new Point(412, 702);
            button21.Name = "button21";
            button21.Size = new Size(94, 29);
            button21.TabIndex = 2;
            button21.Text = "Очистить";
            button21.UseVisualStyleBackColor = false;
            button21.Click += button21_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(192, 22);
            label3.Name = "label3";
            label3.Size = new Size(225, 28);
            label3.TabIndex = 1;
            label3.Text = "История вычислений";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(54, 69);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(452, 604);
            listBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(560, 749);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Справка";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 795);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Конвертер";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListBox listBox1;
        private Button button21;
        private Label label3;
    }
}
