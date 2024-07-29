using System;

namespace CSharp_BangCuuChuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int so;

        private void Form1_Load(object sender, EventArgs e)
        {
            so = 2;
            rdo2.Checked = true;
            for (int i = 1; i <= 10; i++)
            {
                KQ.Text += Environment.NewLine + so.ToString() + " x " + i.ToString() + " = " + (so * i);
                kq1.Items.Add(so.ToString() + " x " + i.ToString() + " = " + (so * i));
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            so = Convert.ToInt32(numericUpDown1.Value);
            KQ.Text = "Kết quả";
            for (int i = 1; i <= 10; i++)
            {
                KQ.Text += Environment.NewLine + so.ToString() + " x " + i.ToString() + " = " + (so * i);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            so = Convert.ToInt32(trackBar1.Value);
            kq1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                kq1.Items.Add(so.ToString() + " x " + i.ToString() + " = " + (so * i));
            }
        }

        private void kiemtraRDO(object sender, EventArgs e)
        {
            kq2.Items.Clear();
            RadioButton r = (RadioButton)sender;
            so = Convert.ToInt32(r.Text);
            for (int i = 1; i <= 10; i++)
            {
                kq2.Items.Add(so.ToString() + " x " + i.ToString() + " = " + (so * i));
            }
        }
    }
}
