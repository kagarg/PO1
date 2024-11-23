namespace Convertor
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button21 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button20 = new Button();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            trackBar2 = new TrackBar();
            trackBar1 = new TrackBar();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabPage3 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(4, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 448);
            tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button21);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button20);
            tabPage1.Controls.Add(button19);
            tabPage1.Controls.Add(button18);
            tabPage1.Controls.Add(button17);
            tabPage1.Controls.Add(button16);
            tabPage1.Controls.Add(button15);
            tabPage1.Controls.Add(button14);
            tabPage1.Controls.Add(button13);
            tabPage1.Controls.Add(button12);
            tabPage1.Controls.Add(numericUpDown2);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(trackBar2);
            tabPage1.Controls.Add(trackBar1);
            tabPage1.Controls.Add(button11);
            tabPage1.Controls.Add(button10);
            tabPage1.Controls.Add(button9);
            tabPage1.Controls.Add(button8);
            tabPage1.Controls.Add(button7);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(776, 415);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Конвертер";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.BackColor = Color.Orange;
            button21.Font = new Font("Segoe UI", 15F);
            button21.ForeColor = SystemColors.ButtonHighlight;
            button21.Location = new Point(191, 333);
            button21.Name = "button21";
            button21.Size = new Size(394, 51);
            button21.TabIndex = 54;
            button21.Text = "Calculate";
            button21.UseVisualStyleBackColor = false;
            button21.Click += button21_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(391, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 27);
            textBox2.TabIndex = 53;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 27);
            textBox1.TabIndex = 52;
            textBox1.KeyUp += Form1_KeyUp;
            // 
            // button20
            // 
            button20.BackColor = Color.FromArgb(128, 255, 255);
            button20.Location = new Point(191, 298);
            button20.Name = "button20";
            button20.Size = new Size(94, 29);
            button20.TabIndex = 51;
            button20.Text = ".";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click_1;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(128, 255, 255);
            button19.Location = new Point(291, 298);
            button19.Name = "button19";
            button19.Size = new Size(94, 29);
            button19.TabIndex = 50;
            button19.Text = "+/-";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click_1;
            // 
            // button18
            // 
            button18.BackColor = Color.IndianRed;
            button18.Location = new Point(391, 298);
            button18.Name = "button18";
            button18.Size = new Size(94, 29);
            button18.TabIndex = 49;
            button18.Text = "BS";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click_1;
            // 
            // button17
            // 
            button17.BackColor = Color.GreenYellow;
            button17.Location = new Point(491, 263);
            button17.Name = "button17";
            button17.Size = new Size(94, 29);
            button17.TabIndex = 48;
            button17.Text = "F";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click_1;
            // 
            // button16
            // 
            button16.BackColor = Color.GreenYellow;
            button16.Location = new Point(391, 263);
            button16.Name = "button16";
            button16.Size = new Size(94, 29);
            button16.TabIndex = 47;
            button16.Text = "E";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click_1;
            // 
            // button15
            // 
            button15.BackColor = Color.GreenYellow;
            button15.Location = new Point(291, 263);
            button15.Name = "button15";
            button15.Size = new Size(94, 29);
            button15.TabIndex = 46;
            button15.Text = "D";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click_1;
            // 
            // button14
            // 
            button14.BackColor = Color.GreenYellow;
            button14.Location = new Point(191, 263);
            button14.Name = "button14";
            button14.Size = new Size(94, 29);
            button14.TabIndex = 45;
            button14.Text = "C";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click_1;
            // 
            // button13
            // 
            button13.BackColor = Color.GreenYellow;
            button13.Location = new Point(491, 228);
            button13.Name = "button13";
            button13.Size = new Size(94, 29);
            button13.TabIndex = 44;
            button13.Text = "B";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click_1;
            // 
            // button12
            // 
            button12.BackColor = Color.GreenYellow;
            button12.Location = new Point(391, 228);
            button12.Name = "button12";
            button12.Size = new Size(94, 29);
            button12.TabIndex = 43;
            button12.Text = "A";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click_1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(456, 30);
            numericUpDown2.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(66, 27);
            numericUpDown2.TabIndex = 42;
            numericUpDown2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged_1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(253, 30);
            numericUpDown1.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(66, 27);
            numericUpDown1.TabIndex = 41;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged_1;
            // 
            // trackBar2
            // 
            trackBar2.LargeChange = 1;
            trackBar2.Location = new Point(419, 63);
            trackBar2.Maximum = 16;
            trackBar2.Minimum = 2;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(138, 56);
            trackBar2.TabIndex = 40;
            trackBar2.TabStop = false;
            trackBar2.Value = 2;
            trackBar2.Scroll += trackBar2_Scroll_1;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(219, 63);
            trackBar1.Maximum = 16;
            trackBar1.Minimum = 2;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(137, 56);
            trackBar1.TabIndex = 39;
            trackBar1.TabStop = false;
            trackBar1.Value = 2;
            trackBar1.Scroll += trackBar1_Scroll_1;
            // 
            // button11
            // 
            button11.BackColor = Color.GreenYellow;
            button11.Location = new Point(191, 158);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 38;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click_1;
            // 
            // button10
            // 
            button10.BackColor = Color.GreenYellow;
            button10.Location = new Point(291, 228);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 37;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click_1;
            // 
            // button9
            // 
            button9.BackColor = Color.GreenYellow;
            button9.Location = new Point(191, 228);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 36;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click_1;
            // 
            // button8
            // 
            button8.BackColor = Color.GreenYellow;
            button8.Location = new Point(491, 193);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 35;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // button7
            // 
            button7.BackColor = Color.GreenYellow;
            button7.Location = new Point(391, 193);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 34;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.GreenYellow;
            button6.Location = new Point(291, 193);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 33;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.GreenYellow;
            button5.Location = new Point(191, 193);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 32;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.GreenYellow;
            button4.Location = new Point(491, 158);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 31;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.GreenYellow;
            button3.Location = new Point(391, 158);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 30;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.GreenYellow;
            button2.Location = new Point(291, 158);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 29;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(491, 298);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 28;
            button1.Text = "CLR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(776, 415);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "История";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(116, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(554, 415);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "P1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "N1";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "P2";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "N2";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(776, 415);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "О программе";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 148);
            label1.Name = "label1";
            label1.Size = new Size(364, 20);
            label1.TabIndex = 0;
            label1.Text = "Конвертер чисел в различных системах счисления";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 362);
            label2.Name = "label2";
            label2.Size = new Size(299, 20);
            label2.TabIndex = 1;
            label2.Text = "Авторы: Курдюков И.Н. Омельницкая Е.И.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Convertor";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button21;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabPage tabPage3;
        private Label label1;
        private Label label2;
    }
}
