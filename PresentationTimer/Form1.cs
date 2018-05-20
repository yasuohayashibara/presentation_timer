using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int count = 0;
        bool is_start = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (is_start)
            {
                count ++;
                if (count > 480) count = 0;
            }
            textBox1.Text = (count / 60).ToString().PadLeft(2, '0') + " : " + (count % 60).ToString().PadLeft(2, '0');
            textBox2.ReadOnly = true;
            if (count < 300)
            {
                textBox2.ForeColor = Color.Blue;
                textBox2.BackColor = Color.White;
                textBox2.Text = "発表";
            }
            else if (count < 420)
            {
                textBox2.ForeColor = Color.Green;
                textBox2.BackColor = Color.White;
                textBox2.Text = "質疑応答";
            }
            else
            {
                textBox2.ForeColor = Color.White;
                textBox2.BackColor = Color.Red;
                textBox2.Text = "交代時間";
            }
            if (count == 300) Console.Beep(4000, 500);
            if (count == 420) Console.Beep(4000, 500);
            if (count == 421) Console.Beep(4000, 500);
            if (count == 480) Console.Beep(4000, 1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            is_start = true;
            count = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
        }
    }
}
