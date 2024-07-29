namespace CSharp_BangCuuChuong
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
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            KQ = new Label();
            trackBar1 = new TrackBar();
            kq1 = new ListBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            rdo10 = new RadioButton();
            rdo9 = new RadioButton();
            rdo5 = new RadioButton();
            rdo8 = new RadioButton();
            rdo4 = new RadioButton();
            rdo7 = new RadioButton();
            rdo2 = new RadioButton();
            rdo3 = new RadioButton();
            rdo6 = new RadioButton();
            kq2 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(107, 49);
            numericUpDown1.Margin = new Padding(6, 7, 6, 7);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(86, 40);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(290, 33);
            label1.TabIndex = 1;
            label1.Text = "Chọn bảng cửu chương";
            // 
            // KQ
            // 
            KQ.AutoSize = true;
            KQ.Location = new Point(12, 96);
            KQ.Name = "KQ";
            KQ.Size = new Size(106, 33);
            KQ.TabIndex = 1;
            KQ.Text = "Kết quả";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(300, 49);
            trackBar1.Minimum = 2;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(325, 45);
            trackBar1.TabIndex = 2;
            trackBar1.Value = 2;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // kq1
            // 
            kq1.ItemHeight = 33;
            kq1.Location = new Point(336, 132);
            kq1.Name = "kq1";
            kq1.Size = new Size(257, 334);
            kq1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 96);
            label2.Name = "label2";
            label2.Size = new Size(129, 33);
            label2.TabIndex = 3;
            label2.Text = "Kết quả 2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdo10);
            groupBox1.Controls.Add(rdo9);
            groupBox1.Controls.Add(rdo5);
            groupBox1.Controls.Add(rdo8);
            groupBox1.Controls.Add(rdo4);
            groupBox1.Controls.Add(rdo7);
            groupBox1.Controls.Add(rdo2);
            groupBox1.Controls.Add(rdo3);
            groupBox1.Controls.Add(rdo6);
            groupBox1.Location = new Point(631, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 124);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả 3";
            // 
            // rdo10
            // 
            rdo10.AutoSize = true;
            rdo10.Location = new Point(222, 65);
            rdo10.Name = "rdo10";
            rdo10.Size = new Size(63, 37);
            rdo10.TabIndex = 0;
            rdo10.TabStop = true;
            rdo10.Text = "10";
            rdo10.UseVisualStyleBackColor = true;
            rdo10.CheckedChanged += kiemtraRDO;
            // 
            // rdo9
            // 
            rdo9.AutoSize = true;
            rdo9.Location = new Point(168, 83);
            rdo9.Name = "rdo9";
            rdo9.Size = new Size(48, 37);
            rdo9.TabIndex = 0;
            rdo9.TabStop = true;
            rdo9.Text = "9";
            rdo9.UseVisualStyleBackColor = true;
            rdo9.CheckedChanged += kiemtraRDO;
            // 
            // rdo5
            // 
            rdo5.AutoSize = true;
            rdo5.Location = new Point(168, 45);
            rdo5.Name = "rdo5";
            rdo5.Size = new Size(48, 37);
            rdo5.TabIndex = 0;
            rdo5.TabStop = true;
            rdo5.Text = "5";
            rdo5.UseVisualStyleBackColor = true;
            rdo5.CheckedChanged += kiemtraRDO;
            // 
            // rdo8
            // 
            rdo8.AutoSize = true;
            rdo8.Location = new Point(114, 83);
            rdo8.Name = "rdo8";
            rdo8.Size = new Size(48, 37);
            rdo8.TabIndex = 0;
            rdo8.TabStop = true;
            rdo8.Text = "8";
            rdo8.UseVisualStyleBackColor = true;
            rdo8.CheckedChanged += kiemtraRDO;
            // 
            // rdo4
            // 
            rdo4.AutoSize = true;
            rdo4.Location = new Point(114, 45);
            rdo4.Name = "rdo4";
            rdo4.Size = new Size(48, 37);
            rdo4.TabIndex = 0;
            rdo4.TabStop = true;
            rdo4.Text = "4";
            rdo4.UseVisualStyleBackColor = true;
            rdo4.CheckedChanged += kiemtraRDO;
            // 
            // rdo7
            // 
            rdo7.AutoSize = true;
            rdo7.Location = new Point(60, 83);
            rdo7.Name = "rdo7";
            rdo7.Size = new Size(48, 37);
            rdo7.TabIndex = 0;
            rdo7.TabStop = true;
            rdo7.Text = "7";
            rdo7.UseVisualStyleBackColor = true;
            rdo7.CheckedChanged += kiemtraRDO;
            // 
            // rdo2
            // 
            rdo2.AutoSize = true;
            rdo2.Location = new Point(6, 45);
            rdo2.Name = "rdo2";
            rdo2.Size = new Size(48, 37);
            rdo2.TabIndex = 0;
            rdo2.TabStop = true;
            rdo2.Text = "2";
            rdo2.UseVisualStyleBackColor = true;
            rdo2.CheckedChanged += kiemtraRDO;
            // 
            // rdo3
            // 
            rdo3.AutoSize = true;
            rdo3.Location = new Point(60, 45);
            rdo3.Name = "rdo3";
            rdo3.Size = new Size(48, 37);
            rdo3.TabIndex = 0;
            rdo3.TabStop = true;
            rdo3.Text = "3";
            rdo3.UseVisualStyleBackColor = true;
            rdo3.CheckedChanged += kiemtraRDO;
            // 
            // rdo6
            // 
            rdo6.AutoSize = true;
            rdo6.Location = new Point(6, 83);
            rdo6.Name = "rdo6";
            rdo6.Size = new Size(48, 37);
            rdo6.TabIndex = 0;
            rdo6.TabStop = true;
            rdo6.Text = "6";
            rdo6.UseVisualStyleBackColor = true;
            rdo6.CheckedChanged += kiemtraRDO;
            // 
            // kq2
            // 
            kq2.ItemHeight = 33;
            kq2.Location = new Point(631, 132);
            kq2.Name = "kq2";
            kq2.Size = new Size(257, 334);
            kq2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 487);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(kq2);
            Controls.Add(kq1);
            Controls.Add(trackBar1);
            Controls.Add(KQ);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Bảng Cửu Chương";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label KQ;
        private TrackBar trackBar1;
        private ListBox kq1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rdo4;
        private RadioButton rdo3;
        private RadioButton rdo5;
        private RadioButton rdo10;
        private RadioButton rdo9;
        private RadioButton rdo8;
        private RadioButton rdo7;
        private RadioButton rdo6;
        private ListBox kq2;
        private RadioButton rdo2;
    }
}
